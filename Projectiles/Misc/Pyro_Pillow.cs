using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Projectiles.Misc
{
	public class Pyro_Pillow : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Harold's ashes in a piece of cloth");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.BeachBall);
			aiType = ProjectileID.BeachBall;
		}
	}
}