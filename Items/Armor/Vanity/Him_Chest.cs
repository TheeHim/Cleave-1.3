using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Body)]
    public class Him_Chest : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Him's Moyai Plate");
            Tooltip.SetDefault("An impenetrable shell of stone that's aged for a milenia.\nGreat for cosplaying as mod devs!");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 9;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }
    }
}