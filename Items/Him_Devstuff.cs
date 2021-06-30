using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace Cleave.Items.Images
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

namespace Cleave.Items.Images
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

namespace Cleave.Items.Images
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

namespace Cleave.Items.Images
{
    public class Stone_Head : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.CursedSapling);

            item.width = 12;
            item.height = 16;
            item.useTime = 25;
            item.useAnimation = 25;

            item.shoot = mod.ProjectileType("Moyai");
            item.buffType = mod.BuffType("Moyai");
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Head");
            Tooltip.SetDefault("A weird looking head made of stone. \nSummons a Moyai.");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
