using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace Cleave.Items.Images
{
    public class Bossmatter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bossmatter");
            Tooltip.SetDefault("Pulsating energy that seems to be connected to the strong creatures of the world.\nUsed to craft Lorebooks, Paintings, and Statues");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 6));
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 44;
            item.maxStack = 999;
            item.rare = ItemRarityID.LightRed;
        }
    }
    public class Mystic_Rock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mystic Stone");
            Tooltip.SetDefault("A pulsating clump of stones used to craft statues of powerful creatures when combined with Bossmatter and a Mask.");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 9));
        }
        public override void SetDefaults()
        {
            item.width = 68;
            item.height = 64;
            item.maxStack = 999;
            item.rare = ItemRarityID.Green;
        }
    }
    public class Magic_Canvas : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Canvas");
            Tooltip.SetDefault("A shining piece of cloth used to make paintings of powerful creatures when combined with Bossmatter and a Trophy.");
            ItemID.Sets.ItemIconPulse[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 7));
        }
        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 48;
            item.maxStack = 999;
            item.rare = ItemRarityID.Green;
        }
    }
}