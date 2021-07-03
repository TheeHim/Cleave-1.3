using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

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
    public class Stone_Head : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Head");
            Tooltip.SetDefault("A weird looking head made of stone. \nSummons a Moyai.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 6));
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.CursedSapling);

            item.width = 16;
            item.height = 20;
            item.useTime = 25;
            item.useAnimation = 25;
            item.rare = ItemRarityID.Cyan;

            item.shoot = mod.ProjectileType("Moyai");
            item.buffType = mod.BuffType("Moyai");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
    [AutoloadEquip(EquipType.Wings)]
    public class Him_Wings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Weird Rune");
            Tooltip.SetDefault("This symbol probably means something...\nCounts as wings.");
        }
        public override void SetDefaults()
        {
            item.width = 52;
            item.height = 48;
            item.accessory = true;
            item.rare = ItemRarityID.Cyan;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 150;
            player.GetModPlayer<CleavePlayer>().HimWing = true;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }
        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 9f;
            acceleration *= 2.5f;
        }
    }
}
