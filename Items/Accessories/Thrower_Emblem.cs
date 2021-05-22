using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Accessories
{
    public class Thrower_Emblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thrower Emblem");
            Tooltip.SetDefault("15% increased thrown damage");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.accessory = true;
            item.value = 100000;
            item.rare = ItemRarityID.LightRed;
        }
        public override void UpdateEquip(Player player)
        {
            player.thrownDamage += 0.15f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.AvengerEmblem);
            recipe.AddRecipe();
        }
    }
}
