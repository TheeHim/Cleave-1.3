using System;
using Terraria;
using Terraria.ModLoader;


namespace Cleave.Projectiles.Misc.Images
{
    public class HisSigil1 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("His Sigil");
        }

        public override void SetDefaults()
        {
            projectile.width = 80;
            projectile.height = 80;
            Main.projPet[projectile.type] = true;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
        }
        public override void AI()
        {
            Player p = Main.player[projectile.owner];
            var player = Main.player[projectile.owner];
            projectile.rotation += (float)projectile.direction * .01f + (Math.Abs(player.velocity.X / 200));
            projectile.position.X = p.Center.X - projectile.width / 2;
            projectile.position.Y = p.Center.Y - projectile.height / 2;
            if (player.GetModPlayer<CleavePlayer>().HimWing == false || player.dead)
            {
                projectile.Kill();
                return;
            }
        }
    }
    public class HisSigil2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("His Sigil");
        }

        public override void SetDefaults()
        {
            projectile.width = 60;
            projectile.height = 60;
            Main.projPet[projectile.type] = true;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
        }
        public override void AI()
        {
            Player p = Main.player[projectile.owner];
            var player = Main.player[projectile.owner];

            projectile.rotation += (projectile.direction * -.01f) - Math.Abs(player.velocity.Y / 200);
            projectile.position.X = p.Center.X - projectile.width / 2;
            projectile.position.Y = p.Center.Y - projectile.height / 2;

            if (player.GetModPlayer<CleavePlayer>().HimWing == false || player.dead)

            {
                projectile.Kill();
                return;
            }
        }
    }
}