using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Legs)]
    public class Him_Boot : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Him's Moyai Pants");
            Tooltip.SetDefault("Leggings with which to traverse the world with.\nGreat for cosplaying as mod devs!");
        }

        public override void SetDefaults()
        {
            item.width = 11;
            item.height = 9;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }
    }
}