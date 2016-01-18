using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using WingZero.Robotics;

namespace WingZero.Robotics
{
	public class InverseKinematicsSolver
	{
		public InverseKinematicsSolver(Robot robot, Vector3 target) 
		{
			TargetError = 0.05f;			
			GradientDelta = 0.001f;
			DampFactor = 0.01f;
			MaxIterations = 150;
			MaxBruteForceIterations = 50;

			Robot = robot;
			TargetPosition = target;
			Mode = ErrorCheckingMode.ByComponent;
		}

		/// <summary>
		/// Robot which IK problem will be resolved
		/// </summary>
		public Robot Robot { get; set; }

		/// <summary>
		/// Effector target position in Robot-space
		/// </summary>
		public Vector3 TargetPosition { get; set; }

		/// <summary>
		/// If Mode is set to ByComponent: Maximum difference each solution effector-position vector component could have compared against target.
		/// If Mode is set to ByDistance: Maximum squared scalar distance between solution effector-position vector and target.
		/// </summary>
		public float TargetError { get; set; }

		/// <summary>
		/// Infinitesimal Delta step approximation used to calculate numeric gradient
		/// </summary>
		public float GradientDelta  { get; set; }

		/// <summary>
		/// Factor to apply gradient velocity accumulation on each component by each iteration.
		/// </summary>
		public float DampFactor { get; set; }

		/// <summary>
		/// Maximum number of iterations to be done in order to match TargetError constraint
		/// </summary>
		public int MaxIterations  { get; set; }

		public int MaxBruteForceIterations { get; set; }

		/// <summary>
		/// Mode used in order to evaluate the TargetError constraint
		/// </summary>
		public ErrorCheckingMode Mode { get; set; }
		
		/// <summary>
		/// Try to resolve the problem by using the Simple Descent Gradient algorithm.
		/// </summary>
		/// <param name="initial">Initial guess</param>
		/// <returns>Numeric solution</returns>
		public InverseKinematicsSolution ProcessSolution(float[] initial)
		{			
			DateTime t0 = DateTime.Now;
			List<InverseKinematicsSolution> solutions = new List<InverseKinematicsSolution>();
			InverseKinematicsSolution solution = new InverseKinematicsSolution() { SolutionMatch = false };			
			Vector3 dist_vector;
			float dist;
			float[] x;
			int iterations;
			int i;
			for (i = 0; !solution.SolutionMatch && i <= MaxBruteForceIterations; i++)
			{
				solution = new InverseKinematicsSolution();
				solution.Status = initial;
				float[] ninitial = i == 0 ? initial : Robot.GetRandomState();
				ApplyDescentGradient(ninitial, out dist_vector, out dist, out x, out iterations);
				solution.Status = x;
				solution.Error = dist;
				solution.VectorError = dist_vector;
				solution.SolutionMatch = iterations < MaxIterations;
				solution.IterationCount = iterations;				
				solutions.Add(solution);
			}			
			solution = solutions.OrderBy(sol => sol.Error).First();
			solution.BruteForceIterationCount = i - 1;
			solution.Time = DateTime.Now - t0;
			return solution;
		}

		private void ApplyDescentGradient(float[] initial, out Vector3 dist_vector, out float dist, out float[] x, out int iterations)
		{
			dist = ComputeDistance(initial, out dist_vector);
			float[] old_gradient = new float[initial.Length];
			x = initial.Clone() as float[];
			float[] speed = new float[initial.Length];
			iterations = 0;
			do
			{
				float[] gradient = ComputeGradient(dist, x);
				for (int i = 0; i < gradient.Length; i++)
				{
					if (old_gradient[i] * gradient[i] < 0.0f) speed[i] = 0.0f;
					float old_speed = speed[i];
					speed[i] += -gradient[i] * DampFactor;
					x[i] += speed[i];
					if (!Robot.IsLinkValidValue(x[i], i))
					{
						speed[i] = old_speed;
						gradient[i] = 0.0f;
					}
				}
				Robot.FixLimits(x);
				dist = ComputeDistance(x, out dist_vector);
				old_gradient = gradient.Clone() as float[];
				iterations++;
			} while (CheckDistance(dist_vector, dist) && iterations < MaxIterations);
		}

		private bool CheckDistance(Vector3 dist_vector, float dist)
		{
			return Mode == ErrorCheckingMode.ByDistance ? 
				// Mode: ByDistance
				dist > TargetError : 
				// Mode: ByComponent
				Math.Abs(dist_vector.X) > TargetError || Math.Abs(dist_vector.Y) > TargetError || Math.Abs(dist_vector.Z) > TargetError;
		}

		/// <summary>
		/// Computes the distance between TargetPosition effector vector and effector vector from specified robot status
		/// </summary>
		/// <param name="u">Current robot status</param>
		/// <param name="d">Distance in vector way</param>
		/// <returns>Distance in squared scalar way</returns>
		private float ComputeDistance(float[] x, out Vector3 d)
		{
			d = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			if (!Robot.IsValidState(x)) return float.MaxValue;
			Vector3 v = Robot.Eval(x);			
			d = TargetPosition - v;
			float dist = d.LengthSquared();
			return dist;
		}

		/// <summary>
		/// Numeric gradient computation.
		/// </summary>
		/// <param name="fb">evaluation of distance in u</param>
		/// <param name="u">evaluation point</param>
		/// <returns>Gradient(X) * dx ->  Gradient(X) * GradientDelta </returns>
		private float[] ComputeGradient(float f, float[] x)
		{
			float[] res = new float[x.Length];
			Vector3 v;
			for (int i = 0; i < x.Length; i++)
			{
				float[] X = x.Clone() as float[];
				X[i] = x[i] + GradientDelta;
				float fd = ComputeDistance(X, out v);
				res[i] = fd - f;
			}
			return res;
		}

		public enum ErrorCheckingMode
		{
			ByDistance,
			ByComponent
		}
	}
	
	public class InverseKinematicsSolution
	{		
		public float[] Status { get; set; }
		public float Error { get; set; }
		public Vector3 VectorError { get; set; }
		public bool SolutionMatch { get; set; }
		public int IterationCount { get; set; }
		public int BruteForceIterationCount { get; set; }
		public TimeSpan Time { get; set; }
	}
}
