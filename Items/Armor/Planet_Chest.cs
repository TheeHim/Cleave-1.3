using Cleave;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class Planet_Chest : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Planetary Breastplate");
            Tooltip.SetDefault("Increases Thrown damage by 30% and Thrown velocity by 40%");
        }

        public override void SetDefaults()
        {
            item.width = 15;
            item.height = 13;
            item.rare = ItemRarityID.Red;
            item.defense = 30;
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownDamage += 0.30f;
            player.thrownVelocity += 0.40f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 16);
            recipe.AddIngredient(mod.GetItem("Planet_Fragment"), 20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}