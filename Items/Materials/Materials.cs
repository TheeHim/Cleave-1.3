using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CleaveModLite.Items.Other
{
	public class BerylliumBronzeBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 9;
			DisplayName.SetDefault("Beryllium Bronze Bar");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 2300;
			item.consumable = false;
			item.rare = ItemRarityID.Blue;
		}
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 1);
			recipe.AddIngredient(ItemID.SilverBar, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}