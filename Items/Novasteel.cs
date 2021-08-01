using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cleave.Items.Images
{
    public class Nova_Wave : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Wave");
            Tooltip.SetDefault("A huge cleaver made of finely tempered Beryllium Bronze.\nHas a chance to cause a lingering explosion on hit.");
        }

        public override void SetDefaults()
        {
            item.damage = 90;
            item.melee = true;
            item.width = 96;
            item.height = 96;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 4;
            item.value = 5000;
            item.useTurn = true;
            item.rare = ItemRarityID.Yellow;
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 20);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1, -1);
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = mod.GetTexture("Items/Images/Nova_Wave_Glow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.Orange,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            int dustIndex = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("NovaFlecks"), 0f, 0f, 0, default, 1f);
            Main.dust[dustIndex].scale = 1f + Main.rand.Next(5) * 0.1f;
            Main.dust[dustIndex].noGravity = true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.NextBool(5))
            {
                Projectile.NewProjectile(target.position.X + target.width / 2, target.position.Y + target.height / 2, 0f, 0f, mod.ProjectileType("Nova_Boom1"), damage, 0f, player.whoAmI, 0f, 0f);
                Projectile.NewProjectile(target.position.X + target.width / 2, target.position.Y + target.height / 2, 0f, 0f, mod.ProjectileType("Nova_Boom2"), damage, 0f, player.whoAmI, 0f, 0f);
                Main.PlaySound(SoundID.Item, (int)target.Center.X, (int)target.Center.Y, 88);
            }
            else
            {
                Main.PlaySound(SoundID.Item, (int)target.Center.X, (int)target.Center.Y, 89);
            }
            for (int i = 0; i < 10; i++)
            {
                _ = Dust.NewDustDirect(target.Center, 10, 10, mod.DustType("NovaFlecks"));
            }
        }
    }
    public class Nova_Effect : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Effect");
            Tooltip.SetDefault("A firey crossbow made of finely tempered Beryllium Bronze.\nFires a barrage of Nova Arrows slowly that create lingering explosions.");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.HallowedRepeater);
            item.damage = 9;
            item.width = 60;
            item.height = 26;
            item.useTime = 15;
            item.useAnimation = 30;
            item.reuseDelay = 100;
            item.knockBack = 4;
            item.shoot = mod.ProjectileType("Nova_Arrow");
            item.value = 5000;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item89;
            item.rare = ItemRarityID.Yellow;
            item.useAmmo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 20);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            for (int i = 0; i < 2; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(4));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, mod.ProjectileType("Nova_Arrow"), damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = mod.GetTexture("Items/Images/Nova_Effect_Glow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.Orange,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }
    }
    public class Nova_Force : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Force");
            Tooltip.SetDefault("A powerful staff made of finely tempered Beryllium Bronze.\nFires short rays of heat rapidly.");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ShadowbeamStaff);
            item.magic = true;
            item.height = 60;
            item.width = 60;
            item.damage = 29;
            item.crit = 10;
            item.useTime = 4;
            item.mana = 4;
            item.noMelee = true;
            item.useAnimation = 12;
            item.knockBack = 4;
            item.shoot = mod.ProjectileType("Nova_Ray");
            item.autoReuse = true;
            item.UseSound = SoundID.Item75;
            item.rare = ItemRarityID.Yellow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 20);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;
            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }
            return true;
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = mod.GetTexture("Items/Images/Nova_Force_Glow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.Orange,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }
    }
    public class Nova_Surge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nova Surge");
            Tooltip.SetDefault("A flaming scepter made of finley tempered Beryllium Bronze\nThrows as many recursive Nova Disks as you have minion slots, though each one out will require half an open slot.");
        }
        public override void SetDefaults()
        {
            item.summon = true;
            item.height = 60;
            item.width = 60;
            item.damage = 62;
            item.crit = 10;
            item.useTime = 20;
            item.noMelee = true;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 4;
            item.shoot = mod.ProjectileType("Nova_Disk");
            item.shootSpeed = 10f;
            item.autoReuse = true;
            item.UseSound = SoundID.Item45;
            item.rare = ItemRarityID.Yellow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 20);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < player.maxMinions;
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Texture2D texture = mod.GetTexture("Items/Images/Nova_Surge_Glow");
            spriteBatch.Draw
            (
                texture,
                new Vector2
                (
                    item.position.X - Main.screenPosition.X + item.width * 0.5f,
                    item.position.Y - Main.screenPosition.Y + item.height - texture.Height * 0.5f + 2f
                ),
                new Rectangle(0, 0, texture.Width, texture.Height),
                Color.Orange,
                rotation,
                texture.Size() * 0.5f,
                scale,
                SpriteEffects.None,
                0f
            );
        }
    }
}