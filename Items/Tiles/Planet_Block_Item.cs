using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Cleave.Items.Materials;

namespace Cleave.Items.Tiles
{
    public class Planet_Block_Item : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Planetary Fragment Block");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 22;
            item.maxStack = 999;
            item.rare = ItemRarityID.White;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.createTile = ModContent.TileType<Planet_Block>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Planet_Fragment>());
            recipe.AddIngredient(ItemID.StoneBlock, 5);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}
