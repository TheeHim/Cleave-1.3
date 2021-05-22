using Cleave;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class Planet_Boot : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Planetary Greaves");
            Tooltip.SetDefault("Thrown damage increased by 20% and movement speed increased by 35%");
        }

        public override void SetDefaults()
        {
            item.width = 11;
            item.height = 9;
            item.rare = ItemRarityID.Red;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownDamage += 0.20f;
            player.moveSpeed += 0.35f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddIngredient(mod.GetItem("Planet_Fragment"), 15);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}