using Cleave;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class Planet_Helm : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Planetary Visor");
			Tooltip.SetDefault("Increases Thrown crit and velocity by 30%");
		}

		public override void SetDefaults()
		{
			item.width = 11;
			item.height = 9;
			item.rare = ItemRarityID.Red;
			item.defense = 16;
		}

		public override void UpdateEquip(Player player)
		{
			player.thrownCrit += 30;
			player.thrownVelocity += 0.30f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<Planet_Chest>() && legs.type == ModContent.ItemType<Planet_Boot>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "The will of the planet is imbued in your palms. Grants 200% increased thrown velocity and 50% chance not to consume thrown items.";
			player.thrownVelocity += 2f;
			player.thrownCost50 = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddIngredient(mod.GetItem("Planet_Fragment"), 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}