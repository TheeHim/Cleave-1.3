using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework.Graphics;

namespace Cleave.Items.Images
{
    public class FLArrow : ModItem
    {
        public override string Texture => "Cleave/Projectiles/Images/FLArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arrow of Flight");
            Tooltip.SetDefault("Hesitates for a moment, then darts at foes with an immense force.");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.FLArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 0f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddIngredient(ItemID.SoulofFlight);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
    public class LArrow : ModItem
    {
        public override string Texture => "Cleave/Projectiles/Images/LArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arrow of Light");
            Tooltip.SetDefault("Becomes a hallowed star on death. Has very short lifetime.");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 18;
            item.height = 40;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.LArrow>();
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddIngredient(ItemID.SoulofLight);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
    public class NArrow : ModItem
    {
        public override string Texture => "Cleave/Projectiles/Images/NArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arrow of Night");
            Tooltip.SetDefault("Has a chance to inflict an evil debuff at the cost of having abysmal damage.");
        }
        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 18;
            item.height = 40;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.NArrow>();
            item.rare = ItemRarityID.LightRed;
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddIngredient(ItemID.SoulofNight);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
    public class SArrow : ModItem
    {
        public override string Texture => "Cleave/Projectiles/Images/SArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arrow of Sight");
            Tooltip.SetDefault("Has poor damage and trajectory, but viscous homing ability.");
        }
        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.SArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 32f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddIngredient(ItemID.SoulofSight);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
    public class MArrow : ModItem
    {
        public override string Texture => "Cleave/Projectiles/Images/MArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arrow of Might");
            Tooltip.SetDefault("So mighty that nothing can stop it! Not even air resistance!");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.MArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 1f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
    public class FRArrow : ModItem
    {
        public override string Texture => "Cleave/Projectiles/Images/FRArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arrow of Fright");
            Tooltip.SetDefault("Splits into three mid flight. Frightful for enemies and bad computers alike!");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 999;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.FRArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}
namespace Cleave.Projectiles.Images
{
    public class FLArrow : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/FLArrow";

        public override void SetDefaults()
        {
            projectile.width = 6;               //The width of projectile hitbox
            projectile.height = 6;              //The height of projectile hitbox
            projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.timeLeft = 1200;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;          //Can the projectile collide with tiles?
            projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
            drawOriginOffsetY = -19;
            drawOffsetX = -4;
            aiType = ProjectileID.Bullet;           //Act exactly like default Bullet
            projectile.light = 0;
            projectile.arrow = true;
        }

        int charge;
        public override void AI()
        {
            projectile.velocity.X *= 0.9f;
            projectile.velocity.Y *= 0.9f;
            charge++;

            projectile.rotation += charge / 2;
            if (charge == 50)
            {
                //for (int i = 0; i < 10; i++)
                if (projectile.owner == Main.myPlayer)
                {
                    //target = Main.MouseWorld;
                    //target.TargetClosest(true);
                    float shootToX = Main.MouseWorld.X - projectile.Center.X;
                    float shootToY = Main.MouseWorld.Y - projectile.Center.Y;
                    float distance = (float)Math.Sqrt((double)(shootToX * shootToX + shootToY * shootToY));
                    Collision.CanHitLine(Main.MouseWorld, 0, 0, projectile.position, projectile.width, projectile.height);

                    distance = 7f / distance;
                    shootToX *= distance * 7;
                    shootToY *= distance * 7;
                    Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootToX, shootToY, mod.ProjectileType("FLArrow2"), projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);

                    projectile.Kill();

                }
            }
        }
    }
    public class FLArrow2 : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/FLArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flight Arrow");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }
        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.timeLeft = 300;
            projectile.scale = 1f;
            projectile.extraUpdates = 3;
            projectile.knockBack = 5f;
            projectile.aiStyle = 1;
            projectile.alpha = 255;
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
            aiType = ProjectileID.Bullet;
            projectile.arrow = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            return true;
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
    public class LArrow : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/LArrow";
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;    //The length of old position to be recorded
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;        //The recording mode
        }

        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 14;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 30;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            aiType = ProjectileID.WoodenArrowFriendly;
            projectile.arrow = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
        }
        public override void Kill(int timeLeft)
        {
            if (projectile.owner == Main.myPlayer)
            {
                // Calculate new speeds for other projectiles.
                // Rebound at 40% to 70% speed, plus a random amount between -8 and 8
                float speedX = projectile.velocity.X + Main.rand.NextFloat(2);
                float speedY = projectile.velocity.Y + Main.rand.NextFloat(2); // This is Vanilla code, a little more obscure.
                                                                               // Spawn the Projectile.
                Projectile.NewProjectile(projectile.position.X + speedX, projectile.position.Y + speedY, speedX, speedY, ProjectileID.HallowStar, projectile.damage, 0f, projectile.owner, 0f, 0f);
            }
        }
    }
    public class NArrow : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/NArrow";

        public override void SetDefaults()
        {
            projectile.width = 3;               //The width of projectile hitbox
            projectile.height = 14;              //The height of projectile hitbox
            projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.timeLeft = 1200;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;          //Can the projectile collide with tiles?
            aiType = ProjectileID.WoodenArrowFriendly;           //Act exactly like default Bullet
            projectile.arrow = true;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.NextBool(2))
            {
                int choice = Main.rand.Next(3);
                if (choice == 0)
                {
                    choice = BuffID.CursedInferno;
                }
                else if (choice == 1)
                {
                    choice = BuffID.Ichor;
                }
                else
                {
                    choice = BuffID.ShadowFlame;
                }
                target.AddBuff(choice, 300);
                projectile.Kill();
            }
        }
    }
    public class SArrow : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/SArrow";
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.Homing[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 14;               //The width of projectile hitbox
            projectile.height = 14;              //The height of projectile hitbox
            projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.timeLeft = 1200;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;          //Can the projectile collide with tiles?
            projectile.extraUpdates = 1;
            aiType = ProjectileID.WoodenArrowFriendly;           //Act exactly like default Bullet
            projectile.arrow = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            if (projectile.localAI[0] == 0f)
            {
                AdjustMagnitude(ref projectile.velocity);
                projectile.localAI[0] = 1f;
            }
            Vector2 move = Vector2.Zero;
            float distance = 200f;
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
                AdjustMagnitude(ref move);
                projectile.velocity = (20 * projectile.velocity + move) / 21f;
                AdjustMagnitude(ref projectile.velocity);
            }
        }
        private void AdjustMagnitude(ref Vector2 vector)
        {
            float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            if (magnitude > 6f)
            {
                vector *= 6f / magnitude;
            }
        }
    }
    public class MArrow : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/MArrow";
        public override void SetDefaults()
        {
            aiType = ProjectileID.Bullet;
            projectile.arrow = true;
            projectile.width = 14;               //The width of projectile hitbox
            projectile.height = 14;              //The height of projectile hitbox
            projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.penetrate = -1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
            projectile.timeLeft = 200;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = false;          //Can the projectile collide with tiles?
            projectile.usesLocalNPCImmunity = true;
            projectile.localNPCHitCooldown = 10;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            projectile.velocity.X = projectile.oldVelocity.X * 1.05f;
            projectile.velocity.Y = projectile.oldVelocity.Y * 1.05f;
        }
    }
    public class FRArrow : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/FRArrow";
        public override void SetDefaults()
        {
            projectile.width = 14;               //The width of projectile hitbox
            projectile.height = 14;              //The height of projectile hitbox
            projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.timeLeft = 30;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;          //Can the projectile collide with tiles?
            aiType = ProjectileID.WoodenArrowFriendly;           //Act exactly like default Bullet
            projectile.arrow = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
            projectile.ai[1] += 1f;
            if (projectile.ai[1] >= 30f)
            {
                // Half a second has passed. Reset timer, etc.
                projectile.ai[0] = 0f;
                projectile.netUpdate = true;
                float speedX = projectile.velocity.X + Main.rand.NextFloat(2);
                float speedY = projectile.velocity.Y + Main.rand.NextFloat(2);
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, speedX, speedY, mod.ProjectileType("FRArrow2"), (projectile.damage / 2), 0f, projectile.owner, 0f, 0f);
                float speedX2 = projectile.velocity.X + Main.rand.NextFloat(2);
                float speedY2 = projectile.velocity.Y + Main.rand.NextFloat(2);
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, speedX2, speedY2, mod.ProjectileType("FRArrow2"), (projectile.damage / 2), 0f, projectile.owner, 0f, 0f);
                float speedX3 = projectile.velocity.X + Main.rand.NextFloat(2);
                float speedY3 = projectile.velocity.Y + Main.rand.NextFloat(2);
                Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, speedX3, speedY3, mod.ProjectileType("FRArrow2"), (projectile.damage / 2), 0f, projectile.owner, 0f, 0f);
            }
        }
    }
    public class FRArrow2 : ModProjectile
    {
        public override string Texture => "Cleave/Projectiles/Images/FRArrow";
        public override void SetDefaults()
        {
            projectile.width = 14;               //The width of projectile hitbox
            projectile.height = 14;              //The height of projectile hitbox
            projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
            projectile.friendly = true;         //Can the projectile deal damage to enemies?
            projectile.hostile = false;         //Can the projectile deal damage to the player?
            projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
            projectile.timeLeft = 300;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
            projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
            projectile.tileCollide = true;          //Can the projectile collide with tiles?
            aiType = ProjectileID.WoodenArrowFriendly;           //Act exactly like default Bullet
            projectile.arrow = true;
        }
    }
}
