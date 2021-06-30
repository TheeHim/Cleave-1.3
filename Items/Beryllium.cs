using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Bar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Ingot");
            Tooltip.SetDefault("A simple alloy. Used in Kiplinjar very often, the knowledge of it must`ve spread to you from there.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.rare = ItemRarityID.Blue;
            item.value = 1000;
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBar);
            recipe.AddRecipeGroup("IronBar");
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinBar);
            recipe.AddRecipeGroup("IronBar");
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Sword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Sword");
        }

        public override void SetDefaults()
        {
            item.damage = 16;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 4;
            item.value = 5000;
            item.useTurn = true;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}


namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Bow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Bow");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodenBow); //Allows you to make the weapon shoot arrows (thats how i do it) 
            item.damage = 14;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 4;
            item.value = 5000;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item5;
            item.useAmmo = AmmoID.Arrow;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Staff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Staff");
            Tooltip.SetDefault("Fires magic daggers that obey gravity after a delay.");
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
            item.knockBack = 10;
            item.value = 5000;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Beryllium_Bronze_Dagger");
            item.shootSpeed = 12f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Pickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Pickaxe");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.autoReuse = true;
            item.melee = true;
            item.pick = 50;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 5;
            item.value = 4000;
            item.useTurn = true;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Axe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Axe");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.autoReuse = true;
            item.melee = true;
            item.axe = 10;
            item.width = 50;
            item.height = 46;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 4;
            item.value = 4000;
            item.useTurn = true;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Hammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Mallet");
        }

        public override void SetDefaults()
        {
            item.damage = 13;
            item.autoReuse = true;
            item.melee = true;
            item.hammer = 50;
            item.width = 56;
            item.height = 56;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 7;
            item.value = 4000;
            item.useTurn = true;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
namespace Cleave.Items.Images
{
    public class Beryllium_Bronze_Shield : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Shield");
            Tooltip.SetDefault("A simple shield of a simple alloy. Gives some defence, and a bit of damage reduction.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.rare = ItemRarityID.Blue;
            item.value = 6000;
            item.accessory = true;
            item.defense = 2;
        }
        public override void UpdateEquip(Player player)
        {
            player.endurance += .05f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Head)]
    public class BB_Melee : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Helm");
            Tooltip.SetDefault("Armor donned by aspiring adventures in Kiplinjar. Suited for warriors.\nBoosts Melee damage by 5%.");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.rare = ItemRarityID.Blue;
            item.value = 5000;
            item.defense = 6;
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.05f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<BB_Chest>() && legs.type == ModContent.ItemType<BB_Boot>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.noKnockback = true;
            player.setBonus = "You cannot be stopped!";
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Head)]
    public class BB_Ranged : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Visage");
            Tooltip.SetDefault("Armor donned by aspiring adventures in Kiplinjar. Suited for hunters.\nBoosts Ranged damage by 5%.");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.rare = ItemRarityID.Blue;
            item.value = 5000;
            item.defense = 4;
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.05f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<BB_Chest>() && legs.type == ModContent.ItemType<BB_Boot>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.noKnockback = true;
            player.setBonus = "You cannot be stopped!";
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Head)]
    public class BB_Magic : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Hat");
            Tooltip.SetDefault("Armor donned by aspiring adventures in Kiplinjar. Suited for mages.\nBoosts Magic damage by 5% and max mana by 40.");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 20;
            item.rare = ItemRarityID.Blue;
            item.value = 5000;
            item.defense = 6;
        }
        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.05f;
            player.statManaMax2 = 40;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<BB_Chest>() && legs.type == ModContent.ItemType<BB_Boot>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.noKnockback = true;
            player.setBonus = "You cannot be stopped!";
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Body)]
    public class BB_Chest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Chestplate");
            Tooltip.SetDefault("Armor donned by aspiring adventures in Kiplinjar.");
        }
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 26;
            item.rare = ItemRarityID.Blue;
            item.value = 7000;
            item.defense = 5;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Legs)]
    public class BB_Boot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beryllium Bronze Helm");
            Tooltip.SetDefault("Armor donned by aspiring adventures in Kiplinjar.");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 18;
            item.rare = ItemRarityID.Blue;
            item.value = 6000;
            item.defense = 2;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Beryllium_Bronze_Bar"), 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}