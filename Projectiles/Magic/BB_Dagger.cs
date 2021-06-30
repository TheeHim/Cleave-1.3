using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

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
	}
}