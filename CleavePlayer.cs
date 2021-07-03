using Terraria;
using Terraria.ModLoader;

namespace Cleave
{
    public class CleavePlayer : ModPlayer
    {
        public bool Moyai;
        public bool HimWing;

        public override void ResetEffects()
        {
            Moyai = false;
            HimWing = false;
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
                }
            }
        }
    }
}