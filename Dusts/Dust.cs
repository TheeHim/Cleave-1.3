using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Cleave.Dusts
{
	public class NovaFlecks : ModDust
	{
		public override void SetDefaults() 
		{
			updateType = 170;
		}
	}
	public class AstralFlecks : ModDust
    {
        public override void SetDefaults()
        {
			updateType = 254;
		}
        public override void OnSpawn(Dust dust)
		{
			dust.frame = new Rectangle(0, Main.rand.Next(3) * 10, 10, 10);
		}
    }
	public class AstralStar : ModDust
    {
        public override void SetDefaults()
        {
			updateType = 16;
        }
        public override void OnSpawn(Dust dust)
		{
			dust.frame = new Rectangle(0, 0, 30, 30);
			dust.scale -= 0.5f;
		}
    }
}