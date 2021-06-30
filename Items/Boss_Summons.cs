using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Images
{
    public class Skeletron_Summon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skull of the Dungeon");
            Tooltip.SetDefault("Might summon manifestations of curses. \nShould only be used at night.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 2;
            item.maxStack = 20;
            item.rare = ItemRarityID.Orange;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return NPC.downedBoss3;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.SkeletronHead);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}
namespace Cleave.Items.Images
{
    public class Flesh_Summon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demonic Skin");
            Tooltip.SetDefault("A sample of Hell`s Leader`s Flesh. Might attract it when presented.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 34;
            item.maxStack = 20;
            item.rare = ItemRarityID.LightRed;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.hardMode;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.WallofFlesh);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}
namespace Cleave.Items.Images
{
    public class Plantera_Summon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bizarre Bulb");
            Tooltip.SetDefault("Nips at your fingers. Holding it makes you feel like there's a tyranical presence nearby.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.maxStack = 20;
            item.rare = ItemRarityID.Lime;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.hardMode && NPC.downedPlantBoss;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Plantera);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}

namespace Cleave.Items.Images
{
    public class Golem_Summon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lihzahrd Doll");
            Tooltip.SetDefault("Impossible to be charged with Voodoo due to the Lihzahrd ways, but will still surely attract attention if treated poorly.\nOnly works in the temple.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.maxStack = 20;
            item.rare = ItemRarityID.Yellow;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.hardMode && NPC.downedGolemBoss;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Golem);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}

namespace Cleave.Items.Images
{
    public class Lunatic_Summon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cultist Voodoo Doll");
            Tooltip.SetDefault("It makes a squeaky sound when you squeeze it. What if you totally pop it? \nBe aware of those Pillars!");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 50;
            item.maxStack = 20;
            item.rare = ItemRarityID.Cyan;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.hardMode && NPC.downedAncientCultist;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.CultistBoss);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}