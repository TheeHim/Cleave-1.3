using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using System.Collections.Generic;

namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Neck)]
    public class Moon_Scarf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Scarf");
            Tooltip.SetDefault("A lil' wormy guy to keep your neck warm. Seems to be from another dimension.\nGlows like the twilight moon.");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 10200;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            Lighting.AddLight((int)(player.position.X / 16f), (int)(player.position.Y / 16f), 1.35f, 1.35f, 1.35f);
        }
        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (slot < 10) // This allows the accessory to equip in Vanity slots with no reservations.
            {
                int maxAccessoryIndex = 5 + player.extraAccessorySlots;
                for (int i = 3; i < 3 + maxAccessoryIndex; i++)
                {
                    // We need "slot != i" because we don't care what is currently in the slot we will be replacing.
                    if (slot != i && player.armor[i].type == ItemID.AnkhShield)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    [AutoloadEquip(EquipType.Head)]
    public class GQuibble_Head : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Green Pianist Bird Mask");
            Tooltip.SetDefault("Perfect for pecking keys with!\n<right> to change color.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 8;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("PQuibble_Head"));
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Piano, 1);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
        }
    }
    [AutoloadEquip(EquipType.Head)]
    public class PQuibble_Head : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Purple Pianist Bird Mask");
            Tooltip.SetDefault("Perfect for pecking keys with!\n<right> to change color.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 8;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            player.QuickSpawnItem(mod.ItemType("GQuibble_Head"));
        }
    }
    [AutoloadEquip(EquipType.Head)]
    public class Puro_Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Goo Wolf Mask");
            Tooltip.SetDefault("Sticks to your face");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 9;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlackInk, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    [AutoloadEquip(EquipType.Body)]
    public class Puro_Chest : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Goo Wolf Suit");
            Tooltip.SetDefault("Makes you feel unfathomably fluffy");
        }
        public override void SetDefaults()
        {
            item.width = 15;
            item.height = 9;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlackInk, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class Puro_Boot : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Goo Wolf Beans");
            Tooltip.SetDefault("Fit for running after tasty white latex");
        }
        public override void SetDefaults()
        {
            item.width = 11;
            item.height = 9;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }
        public override bool DrawHead()
        {
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlackInk, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Cryline_Gem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dubious Gemstone");
            Tooltip.SetDefault("Looks important, as if someone, maybe even a whole race of people hold it dear. You start seeing things when you look through it.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(15, 2));
        }
        public override void SetDefaults()
        {
            item.width = 62;
            item.height = 42;
            item.accessory = true;
            item.rare = ItemRarityID.Orange;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<CleavePlayer>().CrylineSky = true;
            if (hideVisual)
            {
                player.GetModPlayer<CleavePlayer>().CrylineSky = false;
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LargeDiamond);
            recipe.AddIngredient(ItemID.LargeRuby);
            recipe.AddIngredient(ItemID.LargeEmerald);
            recipe.AddIngredient(ItemID.LargeSapphire);
            recipe.AddIngredient(ItemID.LargeTopaz);
            recipe.AddIngredient(ItemID.LargeAmethyst);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}