using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Projectiles.Pets.Images
{
    public class Moyai : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.CursedSapling);

            aiType = ProjectileID.CursedSapling;
            Main.projFrames[projectile.type] = 10;
            projectile.width = 38;
            projectile.height = 61;
            Main.projPet[projectile.type] = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moyai");
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.cSapling = false; // Relic from aiType
            return true;
        }
    }
}
