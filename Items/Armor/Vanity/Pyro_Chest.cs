using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Body)]
    public class Pyro_Chest : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Harold's Flameproof Jacket");
            Tooltip.SetDefault("Equipped with cosmetic Gas Grenades™️!\nGreat for cosplaying as mod devs!");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 9;
            item.rare = ItemRarityID.Cyan;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}