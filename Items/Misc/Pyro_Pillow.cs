using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Misc
{
    public class Pyro_Pillow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("HA40-1D Dakimakura");
            Tooltip.SetDefault("Excellent for torture. Give it a toss!");
        }
        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shootSpeed = 6f;
            item.shoot = ModContent.ProjectileType<Projectiles.Misc.Pyro_Pillow>();
            item.width = 32;
            item.height = 64;
            item.UseSound = SoundID.Item1;
            item.useAnimation = 20;
            item.useTime = 20;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.consumable = true;
        }
    }
}