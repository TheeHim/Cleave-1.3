using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Armor.Vanity
{
    [AutoloadEquip(EquipType.Legs)]
    public class Pyro_Boot : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Harold's Bucket Shoes");
            Tooltip.SetDefault("These. Are buckets.\nGreat for cosplaying as mod devs!");
        }

        public override void SetDefaults()
        {
            item.width = 11;
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