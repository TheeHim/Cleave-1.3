using System;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;

namespace Cleave.Projectiles.Images
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
            projectile.alpha = 255;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            //return Color.White;
            return new Color(255, 255, 255, 0) * (1f - (float)projectile.alpha / 255f);
        }
        public override void AI()
        {
            projectile.ai[0] += 1f;
            {
                // Fade in
                projectile.alpha -= 25;
                if (projectile.alpha < 100)
                {
                    projectile.alpha = 100;
                }
            }
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
        public override void Kill(int timeLeft)
        {
            for (int d = 0; d < 70; d++)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 15, 0f, 0f, 150, new Color(0, 255, 168), 1.5f);
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
            projectile.alpha = 255;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            //return Color.White;
            return new Color(255, 255, 255, 0) * (1f - (float)projectile.alpha / 255f);
        }
        public override void AI()
        {
            projectile.ai[0] += 1f;
            {
                // Fade in
                projectile.alpha -= 25;
                if (projectile.alpha < 100)
                {
                    projectile.alpha = 100;
                }
            }
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