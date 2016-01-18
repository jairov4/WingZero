using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using WingZero.Robotics;

namespace WingZero
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		TrajectoryController trajectory;
		JoystickController joystick;
		HardwareInterfaceController hardware;
		SpriteBatch spriteBatch;
		Model linkModel;		
		Robot robot;
		Matrix world;

		public Game()
		{
			IsMouseVisible = true;
			IsFixedTimeStep = false;
			graphics = new GraphicsDeviceManager(this);
			graphics.PreferMultiSampling = true;
			Content.RootDirectory = "Content";
		}
		
		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{			
			// Setup main world matrix
			world = Matrix.CreateRotationX(-MathHelper.PiOver2);

			// Setup camera
			Camera = new Camera();
			Camera.Position = new Vector3(0.0f, 15.0f, 100.0f);
			Camera.Forward = new Vector3(0, 0, -1);

			// Setup Robot
			robot = new Robot();			

			// Setup TrajectoryController
			InverseKinematicsSolver iks = new InverseKinematicsSolver(robot, new Vector3()) { MaxBruteForceIterations = 0, MaxIterations = 200 };
			InverseKinematicsSolver hardiks = new InverseKinematicsSolver(robot, new Vector3()) { MaxBruteForceIterations = 10, MaxIterations = 100 };

			trajectory = new TrajectoryController(this, robot, iks);
			trajectory.Enabled = false;
			Components.Add(trajectory);

			joystick = new JoystickController(this, robot, iks, hardiks);
			joystick.Enabled = true;
			Components.Add(joystick);

			hardware = new HardwareInterfaceController(this, robot);			
			Components.Add(hardware);

			// Creates the UI
			MainForm mainfrm = new MainForm();
			mainfrm.SetRobotEdit(robot, Content);
			mainfrm.SetTrajectoryController(trajectory);
			mainfrm.SetJoystickController(joystick);
			mainfrm.SetHardwareInterfaceController(hardware);
			mainfrm.Show();

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here			
			robot.AxisHelperModel = this.Content.Load<Model>("Model\\AxisHelper");
			linkModel = this.Content.Load<Model>("Model\\LinkModel");
			foreach (Link link in robot.Chain)
			{
				link.Model = linkModel;
				link.ModelPath = "Model\\LinkModel";
			}					
			
			robot.ShowAxisHelper = true;
			robot.AxisHelperScale = 0.2f;

			robot.Reset();			
			
			Camera.AspectRatio = graphics.GraphicsDevice.Viewport.AspectRatio;			
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		// Set the position of the camera in world space, for our view matrix.
		Camera Camera;			

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			// Allows the game to exit
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
				this.Exit();

			float mp = 0.8f;
			if (Keyboard.GetState().IsKeyDown(Keys.LeftShift))
			{
				mp *= 10.0f;
			}
			if (Keyboard.GetState().IsKeyDown(Keys.Up))
			{
				Camera.TurnUD((float)gameTime.ElapsedGameTime.TotalSeconds * mp);
			}
			if (Keyboard.GetState().IsKeyDown(Keys.Down))
			{
				Camera.TurnUD(-(float)gameTime.ElapsedGameTime.TotalSeconds * mp);
			}
			if (Keyboard.GetState().IsKeyDown(Keys.Right))
			{
				Camera.TurnLR((float)gameTime.ElapsedGameTime.TotalSeconds * mp);
			}
			if (Keyboard.GetState().IsKeyDown(Keys.Left))
			{
				Camera.TurnLR(-(float)gameTime.ElapsedGameTime.TotalSeconds * mp);
			}
			if (Keyboard.GetState().IsKeyDown(Keys.W))
			{
				Camera.Move((float)gameTime.ElapsedGameTime.TotalSeconds * mp * 20.0f, 0.0f);
			}
			if (Keyboard.GetState().IsKeyDown(Keys.S))
			{
				Camera.Move(-(float)gameTime.ElapsedGameTime.TotalSeconds * mp * 20.0f, 0.0f);
			}
			if (Keyboard.GetState().IsKeyDown(Keys.A))
			{
				Camera.Move(0.0f, (float)gameTime.ElapsedGameTime.TotalSeconds * mp * 20.0f);
			}
			if (Keyboard.GetState().IsKeyDown(Keys.D))
			{
				Camera.Move(0.0f, -(float)gameTime.ElapsedGameTime.TotalSeconds * mp * 20.0f);
			}

			trajectory.World = world;
			trajectory.View = Camera.GetViewMatrix();
			trajectory.Projection = Camera.GetProjectionMatrix();

			joystick.World = world;
			joystick.View = Camera.GetViewMatrix();
			joystick.Projection = Camera.GetProjectionMatrix();

			// TODO: Add your update logic here
			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			Matrix view = Camera.GetViewMatrix();
			Matrix proj = Camera.GetProjectionMatrix();			
			robot.Draw(world, view, proj);
		
			base.Draw(gameTime);
		}
		
	}
}


