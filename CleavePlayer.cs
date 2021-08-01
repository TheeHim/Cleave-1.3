using Terraria;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace Cleave
{
    public class CleavePlayer : ModPlayer
    {
        public bool Moyai;
        public bool HimWing;
        public bool CrylineSky;

        public override void ResetEffects()
        {
            Moyai = false;
            HimWing = false;
            CrylineSky = false;
        }
        public override void PostUpdateEquips()
        {
            if (HimWing)
            {
                bool petProjectileNotSpawned = true;
                if (player.ownedProjectileCounts[mod.ProjectileType("HisSigil1")] > 0)
                {
                    petProjectileNotSpawned = false;
                }
                if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
                {
                    Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("HisSigil1"), 0, 0f, player.whoAmI, 0f, 0f);
                    Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("HisSigil2"), 0, 0f, player.whoAmI, 0f, 0f);
                    for (int d = 0; d < 70; d++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150,  new Microsoft.Xna.Framework.Color(0, 255, 168), 1.5f);
                    }
                }
            }
            if (HimWing)
            {

            }
        }
        public override void GetDyeTraderReward(List<int> dyeItemIDsPool)
        {
            dyeItemIDsPool.Add(mod.ItemType("DyeHeliodor"));
            dyeItemIDsPool.Add(mod.ItemType("DyeAquamarine"));
            dyeItemIDsPool.Add(mod.ItemType("DyeMorganite"));
            if (player.ownedLargeGems > 0)
            {
                dyeItemIDsPool.Clear();
                dyeItemIDsPool.Add(mod.ItemType("DyeHeliodor"));
                dyeItemIDsPool.Add(mod.ItemType("DyeAquamarine"));
                dyeItemIDsPool.Add(mod.ItemType("DyeMorganite"));
            }
        }
        public override void UpdateBiomeVisuals()
        {
            player.ManageSpecialBiomeVisuals("Cleave:CrylineSky", CrylineSky, player.Center);
		}
	}
}