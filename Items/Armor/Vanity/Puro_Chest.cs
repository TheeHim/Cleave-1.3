using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor.Vanity
{
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
}