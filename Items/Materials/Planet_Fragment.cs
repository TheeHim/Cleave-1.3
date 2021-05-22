using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Materials
{
    public class Planet_Fragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Planetary Fragment");
            Tooltip.SetDefault("The will of the planet seethes within this fragment.");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.SoulofSight);
            item.width = 13;
            item.height = 13;
            item.maxStack = 999;
            item.value = 1000;
            item.rare = ItemRarityID.Cyan;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar);
            recipe.AddIngredient(ItemID.FragmentVortex);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar);
            recipe.AddIngredient(ItemID.FragmentNebula);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentSolar);
            recipe.AddIngredient(ItemID.FragmentStardust);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentVortex);
            recipe.AddIngredient(ItemID.FragmentNebula);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentVortex);
            recipe.AddIngredient(ItemID.FragmentStardust);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentNebula);
            recipe.AddIngredient(ItemID.FragmentStardust);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }
}