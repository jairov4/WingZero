using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WingZero
{
	public class DrawModel
	{
		public static void Draw(Model model, Matrix World, Matrix View, Matrix Projection)
		{
			Matrix[] transforms = new Matrix[model.Bones.Count];
			model.CopyAbsoluteBoneTransformsTo(transforms);

			// Draw the model. A model can have multiple meshes, so loop.
			foreach (ModelMesh mesh in model.Meshes)
			{
				Matrix world = transforms[mesh.ParentBone.Index] * World;

				// This is where the mesh orientation is set, as well as our camera and projection.
				foreach (BasicEffect effect in mesh.Effects)
				{
					effect.EnableDefaultLighting();
					effect.World = world;
					effect.View = View;
					effect.Projection = Projection;
				}
				// Draw the mesh, using the effects set above.
				mesh.Draw();
			}
		}
	}
}
