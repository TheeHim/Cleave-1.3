using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Cleave;

namespace Cleave.Items.Tools
{
    public class Planet_Hax : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Planetary Hamaxe");
        }
        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = true;
            item.width = 36;
            item.height = 36;
            item.useTime = 28;
            item.useAnimation = 10;
            item.hammer = 100;
            item.axe = 150;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 7;
            item.value = 50000;
            item.rare = ItemRarityID.Red;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Planet_Fragment"), 14);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}