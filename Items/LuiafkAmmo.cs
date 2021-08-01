using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items
{
    public class FLArrowL : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("Luiafk") != null;
        }
        public override string Texture => "Cleave/Projectiles/Images/FLArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unlimited Arrow of Flight");
            Tooltip.SetDefault("Hesitates for a moment, then darts at foes with an immense force.");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 1;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.FLArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 0f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Images.FLArrow>(), 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class LArrowL : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("Luiafk") != null;
        }
        public override string Texture => "Cleave/Projectiles/Images/LArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unlimited Arrow of Light");
            Tooltip.SetDefault("Becomes a hallowed star on death. Has very short lifetime.");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 18;
            item.height = 40;
            item.maxStack = 1;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.LArrow>();
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Images.LArrow>(), 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class NArrowL : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("Luiafk") != null;
        }
        public override string Texture => "Cleave/Projectiles/Images/NArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unlimited Arrow of Night");
            Tooltip.SetDefault("Has a chance to inflict an evil debuff at the cost of having abysmal damage.");
        }
        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 18;
            item.height = 40;
            item.maxStack = 1;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.NArrow>();
            item.rare = ItemRarityID.LightRed;
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Images.NArrow>(), 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class SArrowL : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("Luiafk") != null;
        }
        public override string Texture => "Cleave/Projectiles/Images/SArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unlimited Arrow of Sight");
            Tooltip.SetDefault("Has poor damage and trajectory, but viscous homing ability.");
        }
        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 1;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.SArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 32f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Images.SArrow>(), 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class MArrowL : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("Luiafk") != null;
        }
        public override string Texture => "Cleave/Projectiles/Images/MArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unlimited Arrow of Might");
            Tooltip.SetDefault("So mighty that nothing can stop it! Not even air resistance!");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 1;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.MArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 1f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Images.MArrow>(), 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class FRArrowL : ModItem
    {
        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("Luiafk") != null;
        }
        public override string Texture => "Cleave/Projectiles/Images/FRArrow";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unlimited Arrow of Fright");
            Tooltip.SetDefault("Splits into three mid flight. Frightful for enemies and bad computers alike!");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 14;
            item.height = 44;
            item.maxStack = 1;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.LightRed;
            item.shoot = ModContent.ProjectileType<Projectiles.Images.FRArrow>();   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 16f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Images.FRArrow>(), 3996);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}