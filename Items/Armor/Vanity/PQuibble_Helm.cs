using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class PQuibble_Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Purple Pianist Bird Mask");
            Tooltip.SetDefault("Perfect for pecking keys with.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 8;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("GQuibble_Helm"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}