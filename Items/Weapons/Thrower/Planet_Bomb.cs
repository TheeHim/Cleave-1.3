using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Cleave;

namespace Cleave.Items.Weapons.Thrower
{
    internal class Planet_Bomb : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Planetary Explosive");
        }

        public override void SetDefaults()
        {
            item.damage = 70;
            item.thrown = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 12f;
            item.shoot = ModContent.ProjectileType<Projectiles.Thrower.Planet_Bomb>();
            item.width = 21;
            item.height = 24;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 40;
            item.useTime = 40;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.value = 100000;
            item.rare = ItemRarityID.Red;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("Planet_Fragment"), 18);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
