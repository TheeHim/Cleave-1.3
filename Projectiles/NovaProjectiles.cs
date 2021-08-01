using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Cleave.Projectiles.Images
{
    public class Nova_Arrow : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/Nova_Arrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Arrow");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 3;    //The length of old position to be recorded
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }
        public override void SetDefaults()
        {
            aiType = ProjectileID.WoodenArrowFriendly;
            projectile.width = 18;               //The width of projectile hitbox
            projectile.height = 18;              //The height of projectile hitbox
            projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
            projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;          //Can the projectile collide with tiles?
            projectile.arrow = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            if (Main.rand.Next(2) == 0)
            {
                _ = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("NovaFlecks"), projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 20, default, 0.7f);
            }
        }
        public override void Kill(int timeLeft)
        {
            if (projectile.owner == Main.myPlayer)
            {
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, mod.ProjectileType("Nova_Boom1"), projectile.damage, 0f, projectile.owner, 0f, 0f);
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, mod.ProjectileType("Nova_Boom2"), projectile.damage, 0f, projectile.owner, 0f, 0f);
                Main.PlaySound(SoundID.Item, (int)projectile.Center.X, (int)projectile.Center.Y, 88);
            }
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            //Redraw the projectile with the color not influenced by light
            Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
            for (int k = 0; k < projectile.oldPos.Length; k++)
            {
                Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
                Color color = projectile.GetAlpha(lightColor) * ((projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
                spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
            }
            return true;
        }
    }
    public class Nova_Boom1 : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/Nova_Boom";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Explosion");
        }

        public override void SetDefaults()
        {
            projectile.width = 100;
            projectile.height = 100;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.timeLeft = 100;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.knockBack = .25f;
        }
        public override void AI()
        {
            projectile.rotation += projectile.direction * .2f;
            Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("NovaFlecks"), projectile.rotation * 0.25f, projectile.rotation * 0.25f, 0, default, 0.7f);
        }
    }
    public class Nova_Boom2 : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/Nova_Boom";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Explosion");
        }

        public override void SetDefaults()
        {
            projectile.width = 100;
            projectile.height = 100;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
            projectile.penetrate = -1;
            projectile.timeLeft = 100;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            projectile.knockBack = .25f;
        }
        public override void AI()
        {
            projectile.rotation += projectile.direction * -.2f;
            Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("NovaFlecks"), projectile.rotation * 0.25f, projectile.rotation * 0.25f, 0, default, 0.7f);
        }
    }
    public class Nova_Ray : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            // NO! projectile.aiStyle = 48;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.extraUpdates = 100;
            projectile.timeLeft = 50; // lowered from 300
            projectile.penetrate = 1;
        }
        public override string Texture => "Terraria/Projectile_" + ProjectileID.ShadowBeamFriendly;
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (projectile.velocity.X != oldVelocity.X)
            {
                projectile.position.X = projectile.position.X + projectile.velocity.X;
                projectile.velocity.X = -oldVelocity.X;
            }
            if (projectile.velocity.Y != oldVelocity.Y)
            {
                projectile.position.Y = projectile.position.Y + projectile.velocity.Y;
                projectile.velocity.Y = -oldVelocity.Y;
            }
            return false; // return false because we are handling collision
        }
        public override void AI()
        {
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 9f)
            {
                for (int i = 0; i < 4; i++)
                {
                    Vector2 projectilePosition = projectile.position;
                    projectilePosition -= projectile.velocity * ((float)i * 0.25f);
                    projectile.alpha = 255;
                    // Important, changed 173 to 178!
                    int dust = Dust.NewDust(projectilePosition, 1, 1, mod.DustType("NovaFlecks"), 0f, 0f, 0, default, 1f);
                    Main.dust[dust].noGravity = true;
                    Main.dust[dust].position = projectilePosition;
                    Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.013f;
                    Main.dust[dust].velocity *= 0.2f;
                }
            }
        }
    }
    public class Nova_Disk : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/Nova_Disk";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Disk");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
            ProjectileID.Sets.TrailingMode[projectile.type] = 52;
        }
        public override void SetDefaults()
        {
            projectile.friendly = true;
            projectile.minion = true;
            projectile.timeLeft = 300;
            projectile.aiStyle = 14;
            projectile.scale = 1f;
            projectile.minionSlots = .5f;
            projectile.CloneDefaults(52);
            projectile.tileCollide = false;
            aiType = 52;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            drawOffsetX = 0;
            drawOriginOffsetY = -6;
            projectile.width = 64;
            projectile.height = 64;
        }
        public override void AI()
        {
            if (Main.rand.Next(2) == 0)
            {
                _ = Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("NovaFlecks"), projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 20, default, 0.7f);
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Main.PlaySound(SoundID.NPCHit, (int)projectile.position.X, (int)projectile.position.Y, 3);
        }
    }
}