using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Cleave.Items.Weapons
{
	public class BB_Sword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Beryllium Bronze Sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 2;
			item.value = 2700;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("BB_Bar"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}


namespace Cleave.Items.Weapons
{
	public class BB_Bow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Beryllium Bronze Bow");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.WoodenBow); //Allows you to make the weapon shoot arrows (thats how i do it) 
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 0;
			item.value = 2500;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item5;
			item.useAmmo = AmmoID.Arrow;

		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("BB_Bar"), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

namespace CleaveModLite.Items
{
	public class BB_Staff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Beryllium Bronze Staff");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.magic = true;
			item.mana = 12;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 2300;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ProjectileID.RubyBolt;
			item.shootSpeed = 12f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("BB_Bar"), 10);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}