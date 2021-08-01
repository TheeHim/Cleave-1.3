using System;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;

namespace Cleave.Projectiles.Images
{
    #region Baton
    public class Astral_Baton : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Baton");
        }
        public override void SetDefaults()
        {
            projectile.width = 160;
            projectile.height = 160;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.melee = true;
            projectile.ownerHitCheck = true;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 5;
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
            Player player = Main.player[projectile.owner];
            if (Main.myPlayer == projectile.owner)
            {
                if (!player.channel || player.noItems || player.CCed)
                {
                    projectile.Kill();
                }
            }
            if (Main.rand.Next(120) <= (int)projectile.ai[0])
            {
                int choice = Main.rand.Next(2);
                if (choice == 0)
                {
                    choice = mod.DustType("AstralStar");
                }
                else
                {
                    choice = mod.DustType("AstralFlecks");
                }
                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, 0, 0);
            }
            projectile.Center = player.MountedCenter;
            projectile.position.X += player.width / 2 * player.direction;
            projectile.spriteDirection = player.direction;
            projectile.rotation += (projectile.ai[0] / 200f) * player.direction;
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;
            player.itemRotation = projectile.rotation;
            if (projectile.ai[0] >= 120f)
            {
                float shootToX = Main.MouseWorld.X - projectile.Center.X;
                float shootToY = Main.MouseWorld.Y - projectile.Center.Y;
                float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);
                Collision.CanHitLine(Main.MouseWorld, 0, 0, projectile.position, projectile.width, projectile.height);

                distance = 7f / distance;
                shootToX *= distance * 3f;
                shootToY *= distance * 3f;
                Main.PlaySound(SoundID.Item, (int)projectile.Center.X, (int)projectile.Center.Y, 68);
                Projectile.NewProjectile(player.Center.X, player.Center.Y, shootToX, shootToY, mod.ProjectileType("Astral_Wave"), projectile.damage * 4, projectile.knockBack, projectile.owner);
                projectile.Kill();
            }
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Texture2D texture = Main.projectileTexture[projectile.type];
            spriteBatch.Draw(texture, projectile.Center - Main.screenPosition, null, Color.White, projectile.rotation, new Vector2(texture.Width / 2, texture.Height / 2), 1f, projectile.spriteDirection == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally, 0f);
            return false;
        }
    }
    public class Astral_Wave : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.aiStyle = 1;
            projectile.height = 92;
            projectile.width = 92;
            projectile.tileCollide = false;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.timeLeft = 300;
            projectile.alpha = 10;
            projectile.light = .5f;
            projectile.penetrate = -1;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 0;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White; // So the item's sprite isn't affected by light
        }
        public override void AI()
        {
            projectile.velocity.X = projectile.oldVelocity.X * 1.05f;
            projectile.velocity.Y = projectile.oldVelocity.Y * 1.05f;
            projectile.ai[0] += 1f;
            projectile.alpha -= 25;
            if (projectile.alpha < 100)
            {
                projectile.alpha = 100;
            }
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            int choice = Main.rand.Next(2);
            if (choice == 0)
            {
                choice = mod.DustType("AstralStar");
            }
            else
            {
                choice = mod.DustType("AstralFlecks");
            }
            Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, 0, 0);
        }
    }
    #endregion
    #region Starcannon
    public class Astral_Mine : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Mine");
        }
        public override void SetDefaults()
        {
            projectile.width = 100;
            projectile.height = 100;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.timeLeft = 1000;
        }
        public override void AI()
        {
            projectile.velocity *= .9f;
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 30f)
            {
                projectile.ai[0] = 0f;
                projectile.netUpdate = true;
                Vector2 move = Vector2.Zero;
                float distance = 600f;
                bool target = false;
                for (int k = 0; k < 200; k++)
                {
                    if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5 && Main.npc[k].type != NPCID.TargetDummy)
                    {
                        Vector2 newMove = Main.npc[k].Center - projectile.Center;
                        float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y);
                        if (distanceTo < distance)
                        {
                            move = newMove;
                            distance = distanceTo;
                            target = true;
                        }
                    }
                }
                if (target)
                {
                    Vector2 shootTo = (20 * projectile.velocity + move) / 21f;
                    for (int i = 0; i < 8; i++)
                    {
                        Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootTo.X, shootTo.Y, mod.ProjectileType("Astral_Bolt"), projectile.damage / 4, projectile.knockBack, Main.myPlayer, 0f, 0f);
                    }
                    projectile.Kill();
                }
            }
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item, (int)projectile.Center.X, (int)projectile.Center.Y, 89);
            for (int i = 0; i < 10; i++)
            {
                Dust.NewDustDirect(projectile.Center, projectile.width = 10, projectile.height = 10, mod.DustType("AstralStar"));
            }
            for (int i = 0; i < 10; i++)
            {
                Dust.NewDustDirect(projectile.Center, projectile.width = 10, projectile.height = 10, mod.DustType("AstralFlecks"));
            }
        }
    }
    public class Astral_Bolt : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Bolt");
        }
        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.ranged = true;
            projectile.timeLeft = 300;
            aiType = ProjectileID.Bullet;
        }
        public override void AI()
        {
            projectile.velocity *= 1.05f;
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            if (Main.rand.NextFloat(30f) <= (float)Math.Sqrt(projectile.velocity.X * projectile.velocity.X + projectile.velocity.Y * projectile.velocity.Y))
            {
                int choice = Main.rand.Next(2);
                if (choice == 0)
                {
                    choice = mod.DustType("AstralStar");
                }
                else
                {
                    choice = mod.DustType("AstralFlecks");
                }
                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice);
            }
        }
        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item, (int)projectile.Center.X, (int)projectile.Center.Y, 10);
            for (int i = 0; i < 5; i++)
            {
                Dust.NewDustDirect(projectile.Center, projectile.width = 10, projectile.height = 10, mod.DustType("AstralStar"));
            }
            for (int i = 0; i < 5; i++)
            {
                Dust.NewDustDirect(projectile.Center, projectile.width = 10, projectile.height = 10, mod.DustType("AstralFlecks"));
            }
        }
    }
    #endregion
    #region Knowledge
    public class Astral_Knowledge : ModProjectile
    {
        public override string Texture => "Terraria/Projectile_" + ProjectileID.ShadowBeamFriendly;
        public override void SetDefaults()
        {
            projectile.width = 0;
            projectile.height = 0;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.hide = true;
            projectile.magic = true;
            projectile.ignoreWater = true;
            Main.projPet[projectile.type] = true;
        }
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            player.itemTime = 2;
            player.itemAnimation = 2;
            projectile.position = new Vector2(player.MountedCenter.X - projectile.width / 2, player.MountedCenter.Y - projectile.width / 2);
            projectile.ai[0] += 1f;
            Cleave.DrawDustCircle(player.MountedCenter, projectile.ai[0] / 4f, mod.DustType("AstralStar"), 0, default, 1f, (int)((projectile.ai[0] / 180f) * 10));
            Cleave.DrawDustCircle(player.MountedCenter, projectile.ai[0] / 2.75f, mod.DustType("AstralStar"), 0, default, 1f, (int)((projectile.ai[0] / 180f) * 15));
            Cleave.DrawDustCircle(player.MountedCenter, projectile.ai[0] / 2f, mod.DustType("AstralStar"), 0, default, 1f, (int)((projectile.ai[0] / 180f) * 20));
            if (projectile.ai[0] == 180f)
            {
                Main.PlaySound(SoundID.Item, (int)projectile.Center.X, (int)projectile.Center.Y, 82);
                CombatText.NewText(new Rectangle((int)player.Center.X, (int)player.Center.Y, 20, 20), new Color(0, 0, 255), "Max charge!", true);
            }
            if (projectile.ai[0] >= 180f)
            {
                projectile.ai[0] = 180f;
            }
            if (Main.myPlayer == projectile.owner)
            {
                if (!player.channel || player.noItems || player.CCed || player.statMana <= 0)
                {
                    float shootToX = Main.MouseWorld.X - projectile.Center.X;
                    float shootToY = Main.MouseWorld.Y - projectile.Center.Y;
                    float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);
                    Collision.CanHitLine(Main.MouseWorld, 0, 0, projectile.position, projectile.width, projectile.height);

                    distance = 7f / distance;
                    shootToX *= distance * (1.5f + (projectile.ai[0] / 180f * 3f));
                    shootToY *= distance * (1.5f + (projectile.ai[0] / 180f * 3f));
                    Main.PlaySound(SoundID.Item, (int)projectile.Center.X, (int)projectile.Center.Y, 68);
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, shootToX, shootToY, mod.ProjectileType("Astral_Star"), (int)(projectile.damage + (projectile.ai[0] * 15f)), projectile.knockBack, projectile.owner, projectile.ai[0], projectile.whoAmI);
                    projectile.Kill();
                }
            }
            if (player.statMana >= 0 && projectile.ai[0] <= 179f)
            {
                player.statMana -= 2;
            }
        }
    }
    public class Astral_Star : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Star");
        }
        public override void SetDefaults()
        {
            projectile.height = 100;
            projectile.width = 100;
            projectile.tileCollide = false;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.timeLeft = 300;
            projectile.alpha = 10;
            projectile.light = .5f;
            projectile.penetrate = -1;
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White; // So the item's sprite isn't affected by light
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
            projectile.rotation += projectile.direction * (((Math.Abs(projectile.velocity.X) / 2) + (Math.Abs(projectile.velocity.Y) / 3)) / 50);
            if (Main.rand.Next(300) <= (int)projectile.ai[0])
            {
                int choice = Main.rand.Next(2);
                if (choice == 0)
                {
                    choice = mod.DustType("AstralStar");
                }
                else
                {
                    choice = mod.DustType("AstralFlecks");
                }
                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, 0, 0);
            }
        }
    }
    #endregion
    #region Brush
    /*
    public class Astral_Brush : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Brush");
        }
        public override void SetDefaults()
        {
            projectile.width = 0;
            projectile.height = 0;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 5;
        }
        public override void AI()
        {
            projectile.ai[0] += 1f;
            Player player = Main.player[projectile.owner];
            if (Main.myPlayer == projectile.owner)
            {
                if (!player.channel || player.noItems || player.CCed)
                {
                    projectile.Kill();
                }
            }
            projectile.Center = player.MountedCenter - new Vector2(2 * player.direction, -10);
            projectile.position.X += player.width / 2 * player.direction;
            projectile.spriteDirection = player.direction;
            projectile.rotation = projectile.ai[0] / 4 * player.direction;
            if (projectile.ai[0] == 10f)
            {
                float shootToX = Main.MouseWorld.X - projectile.Center.X;
                float shootToY = Main.MouseWorld.Y - projectile.Center.Y;
                float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);
                distance = 7f / distance;
                shootToX *= distance * 3f;
                shootToY *= distance * 3f;
                Projectile.NewProjectile(player.Center.X, player.Center.Y, shootToX, shootToY, mod.ProjectileType("Astral_Blot"), projectile.damage, projectile.knockBack, projectile.owner);
            }
            if (projectile.ai[0] >= 13f)
            {
                projectile.ai[0] = 13f;
                projectile.ai[1] += 1f;
                if (projectile.ai[1] >= 40f)
                {
                    projectile.ai[1] = 0f;
                    projectile.netUpdate = true;
                    projectile.Kill();
                }
            }
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;
            player.itemRotation = projectile.rotation;
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Texture2D texture = Main.projectileTexture[projectile.type];
            spriteBatch.Draw(texture, projectile.Center - Main.screenPosition, null, Color.White, projectile.rotation, new Vector2(texture.Width / 2, texture.Height / 2), 1f, projectile.spriteDirection == 1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally, 0f);
            return false;
        }
    }
    */
    public class Astral_Blot : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Astral Blotch");
            Main.projFrames[projectile.type] = 4;
        }
        public override void SetDefaults()
        {
            projectile.width = 164;
            projectile.height = 164;
            projectile.friendly = true;
            projectile.penetrate = 40;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.minion = true;
            projectile.sentry = true;
            projectile.alpha = 255;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 0;
            projectile.timeLeft = 5000;
        }
        public override void AI()
        {
            projectile.alpha -= 25;
            if (projectile.alpha < 100)
            {
                projectile.alpha = 100;
            }
            projectile.velocity *= .9f;
            Main.player[projectile.owner].UpdateMaxTurrets();
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            AnimateProjectile();
        }
        public void AnimateProjectile()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 10)
            {
                projectile.frame++;
                projectile.frame %= 4;
                projectile.frameCounter = 0;
            }
        }
    }
}
#endregion