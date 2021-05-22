using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class Pyro_Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Harold's Gas Mask");
            Tooltip.SetDefault("Straight out of hell.\nGreat for cosplaying as mod devs!");
        }

        public override void SetDefaults()
        {
            item.width = 13;
            item.height = 12;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}