using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Images
{
    public class Bossmatter : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bossmatter");
			Tooltip.SetDefault("Pulsating energy that seems to be connected to the strong creatures of the world.\nUsed to craft past boss summon items much easier, even a few new ones. \nCan also combine with a boss trophy to aquire the lore of it.");
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.width = 38;
			item.height = 44;
			item.maxStack = 999;
			item.rare = ItemRarityID.LightRed;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.Gel);
            recipe.SetResult(ItemID.SlimeCrown);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.DemoniteBar);
            recipe.SetResult(ItemID.SuspiciousLookingEye);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.CrimtaneBar);
            recipe.SetResult(ItemID.SuspiciousLookingEye);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.ShadowScale);
            recipe.SetResult(ItemID.WormFood);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.TissueSample);
            recipe.SetResult(ItemID.BloodySpine);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.BeeWax);
            recipe.SetResult(ItemID.Abeemination);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.Bone);
            recipe.SetResult(mod.ItemType("Skeletron_Summon"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.SoulofNight);
            recipe.SetResult(mod.ItemType("Flesh_Summon"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.SoulofSight);
            recipe.SetResult(ItemID.MechanicalEye);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.SetResult(ItemID.MechanicalWorm);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.SetResult(ItemID.MechanicalSkull);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.Ectoplasm);
            recipe.SetResult(mod.ItemType("Plantera_Summon"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.LihzahrdBrick);
            recipe.SetResult(mod.ItemType("Golem_Summon"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.MartianConduitPlating);
            recipe.SetResult(ItemID.TruffleWorm);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddRecipeGroup("Cleave:LFragments");
            recipe.SetResult(mod.ItemType("Lunatic_Summon"), 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 3);
            recipe.AddIngredient(ItemID.LunarBar);
            recipe.SetResult(ItemID.CelestialSigil);
            recipe.AddRecipe();
        }
    }
}