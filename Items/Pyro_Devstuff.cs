using Terraria.ModLoader;
using Terraria.ID;

namespace Cleave.Items.Images
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

namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Body)]
    public class Pyro_Chest : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Harold's Flameproof Jacket");
            Tooltip.SetDefault("Equipped with cosmetic Gas Grenades!\nGreat for cosplaying as mod devs!");
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

namespace Cleave.Items.Images
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