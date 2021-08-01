using Terraria;
using Terraria.ModLoader;

namespace Cleave.Items.Images
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string bossBag, Player player, int arg)
        {
            if (Main.rand.NextBool(20))
            {
                switch (Main.rand.Next(2))
                {
                    case 0:
                        {
                            player.QuickSpawnItem(ModContent.ItemType<Him_Helm>());
                            player.QuickSpawnItem(ModContent.ItemType<Him_Chest>());
                            player.QuickSpawnItem(ModContent.ItemType<Him_Boot>());
                            player.QuickSpawnItem(ModContent.ItemType<Stone_Head>());
                            player.QuickSpawnItem(ModContent.ItemType<Him_Wings>());
                        }
                        break;
                    case 1:
                        {
                            if (Main.rand.NextBool(20))
                            {
                                player.QuickSpawnItem(ModContent.ItemType<Pyro_Helm>());
                                player.QuickSpawnItem(ModContent.ItemType<Pyro_Chest>());
                                player.QuickSpawnItem(ModContent.ItemType<Pyro_Boot>());
                            }
                        }
                        break;
                }
            }
            if (Main.rand.NextBool(3))
            {
                player.QuickSpawnItem(ModContent.ItemType<Bossmatter>(), 1 + Main.rand.Next(3));
            }
        }
    }
    /*
    public class BagCat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskCat"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Cat_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Cat_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Cat_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Cat_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Cat_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossCat");
    }
    public class BagSpider : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskSpider"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Spider_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Spider_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Spider_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Spider_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Spider_Expert"));
            player.QuickSpawnItem(mod.ItemType("Bar_Toxite"), 15 + Main.rand.Next(15));
        }
        public override int BossBagNPC => mod.NPCType("BossSpider");
    }
    public class BagCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskCrystal"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Crystal_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Crystal_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Crystal_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Crystal_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Crystal_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossCrystal");
    }
    public class BagSnake : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskSnake"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Snake_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Snake_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Snake_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Snake_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Snake_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossSnake");
    }
    public class BagGirl : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskGirl"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Girl_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Girl_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Girl_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Girl_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Terminite_Frag"), 25 + Main.rand.Next(15));
            player.QuickSpawnItem(mod.ItemType("Terminite_Fire"), 15 + Main.rand.Next(15));
            player.QuickSpawnItem(mod.ItemType("Girl_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossGirl");
    }
    public class BagCold : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskCold"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Cold_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Cold_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Cold_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Cold_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Cold_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossCold");
    }
    public class BagBird : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskBird"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Bird_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Bird_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Bird_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Bird_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Bird_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossBird");
    }
    public class BagAss : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskAss"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Ass_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Ass_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Ass_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Ass_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Ass_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossAss");
    }
    public class BagGoat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskAsgore"));
            }
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskToriel"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Goat_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Goat_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Goat_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Goat_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Goat_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossGoat");
    }
    public class BagFire : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskFire"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Fire_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Fire_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Fire_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Fire_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Fire_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossFire");
    }
    public class BagWater : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskWater"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Water_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Water_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Water_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Water_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Water_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossCat");
    }
    public class BagWitch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskWitch"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Witch_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Witch_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Witch_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Witch_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Witch_Expert"));
            player.QuickSpawnItem(mod.ItemType("Solagel"), 35 + Main.rand.Next(25));
        }
        public override int BossBagNPC => mod.NPCType("BossWitch");
    }
    public class BagSquid : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskSquid"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Squid_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Squid_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Squid_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Squid_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Squid_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossSquid");
    }
    public class BagBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskBall"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Ball_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Ball_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Ball_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Ball_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Terminal_Frag"), 25 + Main.rand.Next(25));
            player.QuickSpawnItem(mod.ItemType("Ball_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossBall");
    }
    public class BagGod : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskGod"));
            }
            player.QuickSpawnItem(mod.ItemType("Bar_Vividite"), 30 + Main.rand.Next(20));
            player.QuickSpawnItem(mod.ItemType("God_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossGod");
    }
    public class BagBoy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskBoy"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Boy_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Boy_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Boy_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Boy_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Boy_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossBoy");
    }
    public class BagSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskSword"));
            }
            if (Main.rand.NextFloat() < .15f)
            {
                player.QuickSpawnItem(mod.ItemType("Hook_Sword"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Sword_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Sword_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Sword_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Sword_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Bar_Randomite"), 40 + Main.rand.Next(10));
            player.QuickSpawnItem(mod.ItemType("Sword_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossSword");
    }
    public class BagFox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskFox"));
            }
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskBlood"));
            }
            switch (Main.rand.Next(2))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Fox_Wep1"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Fox_Wep2"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Fox_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossFox");
    }
    public class BagBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskBook"));
            }
            switch (Main.rand.Next(2))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Book_Wep1"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Book_Wep2"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Book_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossCat");
    }
    public class BagHero : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskOld"));
            }
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskYoung"));
            }
            switch (Main.rand.Next(2))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Hero_Wep1"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Hero_Wep2"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Hero_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossHero");
    }
    public class BagStop : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open.");
        }
        public override void SetDefaults()
        {
            item.height = 36;
            item.width = 36;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }
        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            if (Main.rand.NextBool(7))
            {
                player.QuickSpawnItem(mod.ItemType("MaskStop"));
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    player.QuickSpawnItem(mod.ItemType("Stop_Melee"));
                    break;
                case 1:
                    player.QuickSpawnItem(mod.ItemType("Stop_Ranged"));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("Stop_Magic"));
                    break;
                case 3:
                    player.QuickSpawnItem(mod.ItemType("Stop_Summon"));
                    break;
            }
            player.QuickSpawnItem(mod.ItemType("Bar_Endurnum"), 40 + Main.rand.Next(10));
            player.QuickSpawnItem(mod.ItemType("Stop_Expert"));
        }
        public override int BossBagNPC => mod.NPCType("BossStop");
    }
    */
}