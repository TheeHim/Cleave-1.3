using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Head)]
    public class Puro_Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Goo Wolf Mask");
            Tooltip.SetDefault("Sticks to your face");
        }

        public override void SetDefaults()
        {
            item.width = 10;
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

namespace Cleave.Items.Images
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

namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Legs)]
    public class Puro_Boot : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Goo Wolf Beans");
            Tooltip.SetDefault("Fit for running after tasty white latex");
        }

        public override void SetDefaults()
        {
            item.width = 11;
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