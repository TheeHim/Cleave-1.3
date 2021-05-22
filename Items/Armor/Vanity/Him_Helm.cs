using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class Him_Helm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Him's Moyai Mask");
            Tooltip.SetDefault("Stone eyes that reveal the truth.\nGreat for cosplaying as mod devs!");
        }

        public override void SetDefaults()
        {
            item.width = 9;
            item.height = 11;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}