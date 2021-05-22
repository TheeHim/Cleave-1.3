using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class GQuibble_Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Green Pianist Bird Mask");
            Tooltip.SetDefault("Perfect for pecking keys with.");
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

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Piano, 1);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("PQuibble_Helm"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}