using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ObjectData;

namespace Cleave.Projectiles.Magic.Images
{
	public class Beryllium_Bronze_Dagger : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bery Dagger");
		}

		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 28;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.magic = true;
		}
		public override void AI()
		{
			if (Main.rand.Next(2) == 0) // only spawn 20% of the time
			{
				int choice = Main.rand.Next(3); // choose a random number: 0, 1, or 2
				if (choice == 0) // use that number to select dustID: 15, 57, or 58
				{
					choice = 218;
				}
				else if (choice == 1)
				{
					choice = 266;
				}
				else
				{
					choice = 235;
				}
				// Spawn the dust
				Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default, 0.7f);
			}
		}
		public override void Kill(int timeLeft)
		{
			if (projectile.owner == Main.myPlayer)
			{
				for (int i = 0; i < 10; i++)
				{
                    _ = Dust.NewDustDirect(projectile.Center, projectile.width = 10, projectile.height = 10, 218);
                }
			}
		}
	}
}