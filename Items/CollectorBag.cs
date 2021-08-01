using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;

namespace Cleave.Items.Images
{
    public class Collector_Bag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Collector`s Bag");
            Tooltip.SetDefault("A bag made of condensed Bossmatter that grants a random boss collectable. Might even give you something from someone you haven`t even beaten yet!\nGrants another item in Expert mode!");
            ItemID.Sets.ItemIconPulse[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 36;
            item.maxStack = 999;
            item.rare = ItemRarityID.LightRed;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            switch (Main.rand.Next(6))
            {
                case 0:
                    {
                        switch (Main.rand.Next(17))
                        {
                            case 0:
                                player.QuickSpawnItem(ItemID.KingSlimeMask);
                                break;
                            case 1:
                                player.QuickSpawnItem(ItemID.EyeMask);
                                break;
                            case 2:
                                player.QuickSpawnItem(ItemID.EaterMask);
                                break;
                            case 3:
                                player.QuickSpawnItem(ItemID.BrainMask);
                                break;
                            case 4:
                                player.QuickSpawnItem(ItemID.BeeMask);
                                break;
                            case 5:
                                player.QuickSpawnItem(ItemID.SkeletronMask);
                                break;
                            case 6:
                                player.QuickSpawnItem(ItemID.FleshMask);
                                break;
                            case 7:
                                player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                break;
                            /*
                        case 7:
                            player.QuickSpawnItem(ItemID.QueenSlimeMask);
                            break;
                            */
                            case 8:
                                player.QuickSpawnItem(ItemID.TwinMask);
                                break;
                            case 9:
                                player.QuickSpawnItem(ItemID.DestroyerMask);
                                break;
                            case 10:
                                player.QuickSpawnItem(ItemID.SkeletronPrimeMask);
                                break;
                            case 11:
                                player.QuickSpawnItem(ItemID.PlanteraMask);
                                break;
                            case 12:
                                player.QuickSpawnItem(ItemID.GolemMask);
                                break;
                            case 13:
                                player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                break;
                            /*
                        case 13:
                            player.QuickSpawnItem(ItemID.FairyQueenMask);
                            break;
                            */
                            case 14:
                                player.QuickSpawnItem(ItemID.DukeFishronMask);
                                break;
                            case 15:
                                player.QuickSpawnItem(ItemID.BossMaskCultist);
                                break;
                            case 16:
                                player.QuickSpawnItem(ItemID.BossMaskMoonlord);
                                break;
                                /* oh lord it is going to be five years before even one of these is used oh heavens
                            case 17:
                                player.QuickSpawnItem(mod.ItemType("MaskCat"));
                                break;
                            case 18:
                                player.QuickSpawnItem(mod.ItemType("MaskSpider"));
                                break;
                            case 19:
                                player.QuickSpawnItem(mod.ItemType("MaskCrystal"));
                                break;
                            case 20:
                                player.QuickSpawnItem(mod.ItemType("MaskSnake"));
                                break;
                            case 21:
                                player.QuickSpawnItem(mod.ItemType("MaskGirl"));
                                break;
                            case 22:
                                player.QuickSpawnItem(mod.ItemType("MaskCold"));
                                break;
                            case 23:
                                player.QuickSpawnItem(mod.ItemType("MaskBird"));
                                break;
                            case 24:
                                player.QuickSpawnItem(mod.ItemType("MaskAss"));
                                break;
                            case 25:
                                player.QuickSpawnItem(mod.ItemType("MaskAsgore"));
                                break;
                            case 26:
                                player.QuickSpawnItem(mod.ItemType("MaskToriel"));
                                break;
                            case 27:
                                player.QuickSpawnItem(mod.ItemType("MaskFire"));
                                break;
                            case 28:
                                player.QuickSpawnItem(mod.ItemType("MaskWater"));
                                break;
                            case 29:
                                player.QuickSpawnItem(mod.ItemType("MaskWitch"));
                                break;
                            case 30:
                                player.QuickSpawnItem(mod.ItemType("MaskSquid"));
                                break;
                            case 31:
                                player.QuickSpawnItem(mod.ItemType("MaskBall"));
                                break;
                            case 32:
                                player.QuickSpawnItem(mod.ItemType("MaskGod"));
                                break;
                            case 33:
                                player.QuickSpawnItem(mod.ItemType("MaskBoy"));
                                break;
                            case 34:
                                player.QuickSpawnItem(mod.ItemType("MaskSword"));
                                break;
                            case 35:
                                player.QuickSpawnItem(mod.ItemType("MaskFox"));
                                break;
                            case 36:
                                player.QuickSpawnItem(mod.ItemType("MaskBlood"));
                                break;
                            case 37:
                                player.QuickSpawnItem(mod.ItemType("MaskBook"));
                                break;
                            case 38:
                                player.QuickSpawnItem(mod.ItemType("MaskOld"));
                                break;
                            case 39:
                                player.QuickSpawnItem(mod.ItemType("MaskYoung"));
                                break;
                            case 40:
                                player.QuickSpawnItem(mod.ItemType("MaskStop"));
                                break;
                                */
                        }
                        break;
                    }
                case 1:
                    {
                        switch (Main.rand.Next(17))
                        {
                            case 0:
                                player.QuickSpawnItem(ItemID.KingSlimeTrophy);
                                break;
                            case 1:
                                player.QuickSpawnItem(ItemID.EyeofCthulhuTrophy);
                                break;
                            case 2:
                                player.QuickSpawnItem(ItemID.EaterofWorldsTrophy);
                                break;
                            case 3:
                                player.QuickSpawnItem(ItemID.BrainofCthulhuTrophy);
                                break;
                            case 4:
                                player.QuickSpawnItem(ItemID.QueenBeeTrophy);
                                break;
                            case 5:
                                player.QuickSpawnItem(ItemID.SharkteethTrophy);
                                break;
                            case 6:
                                player.QuickSpawnItem(ItemID.WallofFleshTrophy);
                                break;
                            case 7:
                                player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                break;
                            /*
                        case 7:
                            player.QuickSpawnItem(ItemID.QueenSlimeTrophy);
                            break;
                            */
                            case 8:
                                player.QuickSpawnItem(ItemID.SpazmatismTrophy);
                                break;
                            case 9:
                                player.QuickSpawnItem(ItemID.DestroyerTrophy);
                                break;
                            case 10:
                                player.QuickSpawnItem(ItemID.SkeletronPrimeTrophy);
                                break;
                            case 11:
                                player.QuickSpawnItem(ItemID.PlanteraTrophy);
                                break;
                            case 12:
                                player.QuickSpawnItem(ItemID.GolemMask);
                                break;
                            case 13:
                                player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                break;
                            /*
                        case 13:
                            player.QuickSpawnItem(ItemID.FairyQueenMask);
                            break;
                            */
                            case 14:
                                player.QuickSpawnItem(ItemID.DukeFishronMask);
                                break;
                            case 15:
                                player.QuickSpawnItem(ItemID.BossMaskCultist);
                                break;
                            case 16:
                                player.QuickSpawnItem(ItemID.BossMaskMoonlord);
                                break;
                                /* oh lord it is going to be five years before even one of these is used oh heavens
                            case 17:
                                player.QuickSpawnItem(mod.ItemType("MaskCat"));
                                break;
                            case 18:
                                player.QuickSpawnItem(mod.ItemType("MaskSpider"));
                                break;
                            case 19:
                                player.QuickSpawnItem(mod.ItemType("MaskCrystal"));
                                break;
                            case 20:
                                player.QuickSpawnItem(mod.ItemType("MaskSnake"));
                                break;
                            case 21:
                                player.QuickSpawnItem(mod.ItemType("MaskGirl"));
                                break;
                            case 22:
                                player.QuickSpawnItem(mod.ItemType("MaskCold"));
                                break;
                            case 23:
                                player.QuickSpawnItem(mod.ItemType("MaskBird"));
                                break;
                            case 24:
                                player.QuickSpawnItem(mod.ItemType("MaskAss"));
                                break;
                            case 25:
                                player.QuickSpawnItem(mod.ItemType("MaskAsgore"));
                                break;
                            case 26:
                                player.QuickSpawnItem(mod.ItemType("MaskToriel"));
                                break;
                            case 27:
                                player.QuickSpawnItem(mod.ItemType("MaskFire"));
                                break;
                            case 28:
                                player.QuickSpawnItem(mod.ItemType("MaskWater"));
                                break;
                            case 29:
                                player.QuickSpawnItem(mod.ItemType("MaskWitch"));
                                break;
                            case 30:
                                player.QuickSpawnItem(mod.ItemType("MaskSquid"));
                                break;
                            case 31:
                                player.QuickSpawnItem(mod.ItemType("MaskBall"));
                                break;
                            case 32:
                                player.QuickSpawnItem(mod.ItemType("MaskGod"));
                                break;
                            case 33:
                                player.QuickSpawnItem(mod.ItemType("MaskBoy"));
                                break;
                            case 34:
                                player.QuickSpawnItem(mod.ItemType("MaskSword"));
                                break;
                            case 35:
                                player.QuickSpawnItem(mod.ItemType("MaskFox"));
                                break;
                            case 36:
                                player.QuickSpawnItem(mod.ItemType("MaskBlood"));
                                break;
                            case 37:
                                player.QuickSpawnItem(mod.ItemType("MaskBook"));
                                break;
                            case 38:
                                player.QuickSpawnItem(mod.ItemType("MaskOld"));
                                break;
                            case 39:
                                player.QuickSpawnItem(mod.ItemType("MaskYoung"));
                                break;
                            case 40:
                                player.QuickSpawnItem(mod.ItemType("MaskStop"));
                                break;
                                */
                        }
                        break;
                    }
                case 2:
                    {
                        switch (Main.rand.Next(17))
                        {
                            case 0:
                                player.QuickSpawnItem(mod.ItemType("StatueSlimeItem"));
                                break;
                            case 1:
                                player.QuickSpawnItem(mod.ItemType("StatueEyeItem"));
                                break;
                            case 2:
                                player.QuickSpawnItem(mod.ItemType("StatueEaterItem"));
                                break;
                            case 3:
                                player.QuickSpawnItem(mod.ItemType("StatueBrainItem"));
                                break;
                            case 4:
                                player.QuickSpawnItem(mod.ItemType("StatueBeeItem"));
                                break;
                            case 5:
                                player.QuickSpawnItem(mod.ItemType("StatueSkeleItem"));
                                break;
                            case 6:
                                player.QuickSpawnItem(mod.ItemType("StatueFleshItem"));
                                break;
                            case 7:
                                player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                break;
                            /*
                        case 7:
                            player.QuickSpawnItem(mod.ItemType("StatueQSlimeItem"));
                            break;
                            */
                            case 8:
                                player.QuickSpawnItem(mod.ItemType("StatueTwinItem"));
                                break;
                            case 9:
                                player.QuickSpawnItem(mod.ItemType("StatueDestItem"));
                                break;
                            case 10:
                                player.QuickSpawnItem(mod.ItemType("StatuePrimeItem"));
                                break;
                            case 11:
                                player.QuickSpawnItem(mod.ItemType("StatuePlantItem"));
                                break;
                            case 12:
                                player.QuickSpawnItem(mod.ItemType("StatueGolemItem"));
                                break;
                            case 13:
                                player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                break;
                            /*
                        case 13:
                            player.QuickSpawnItem(mod.ItemType("StatueLightItem"));
                            break;
                            */
                            case 14:
                                player.QuickSpawnItem(mod.ItemType("StatueDukeItem"));
                                break;
                            case 15:
                                player.QuickSpawnItem(mod.ItemType("StatueCultItem"));
                                break;
                            case 16:
                                player.QuickSpawnItem(mod.ItemType("StatueMoonItem"));
                                break;
                                /* oh lord it is going to be five years before even one of these is used oh heavens
                            case 17:
                                player.QuickSpawnItem(mod.ItemType("StatueCatItem"));
                                break;
                            case 18:
                                player.QuickSpawnItem(mod.ItemType("StatueSpiderItem"));
                                break;
                            case 19:
                                player.QuickSpawnItem(mod.ItemType("StatueCrystalItem"));
                                break;
                            case 20:
                                player.QuickSpawnItem(mod.ItemType("StatueSnakeItem"));
                                break;
                            case 21:
                                player.QuickSpawnItem(mod.ItemType("StatueGirlItem"));
                                break;
                            case 22:
                                player.QuickSpawnItem(mod.ItemType("StatueColdItem"));
                                break;
                            case 23:
                                player.QuickSpawnItem(mod.ItemType("StatueBirdItem"));
                                break;
                            case 24:
                                player.QuickSpawnItem(mod.ItemType("StatueAssItem"));
                                break;
                            case 25:
                                player.QuickSpawnItem(mod.ItemType("StatueAsgoreItem"));
                                break;
                            case 26:
                                player.QuickSpawnItem(mod.ItemType("StatueTorielItem"));
                                break;
                            case 27:
                                player.QuickSpawnItem(mod.ItemType("StatueFireItem"));
                                break;
                            case 28:
                                player.QuickSpawnItem(mod.ItemType("StatueWaterItem"));
                                break;
                            case 29:
                                player.QuickSpawnItem(mod.ItemType("StatueWitchItem"));
                                break;
                            case 30:
                                player.QuickSpawnItem(mod.ItemType("StatueSquidItem"));
                                break;
                            case 31:
                                player.QuickSpawnItem(mod.ItemType("StatueBallItem"));
                                break;
                            case 32:
                                player.QuickSpawnItem(mod.ItemType("StatueGodItem"));
                                break;
                            case 33:
                                player.QuickSpawnItem(mod.ItemType("StatueBoyItem"));
                                break;
                            case 34:
                                player.QuickSpawnItem(mod.ItemType("StatueSwordItem"));
                                break;
                            case 35:
                                player.QuickSpawnItem(mod.ItemType("StatueFoxItem"));
                                break;
                            case 36:
                                player.QuickSpawnItem(mod.ItemType("StatueBloodItem"));
                                break;
                            case 37:
                                player.QuickSpawnItem(mod.ItemType("StatueBookItem"));
                                break;
                            case 38:
                                player.QuickSpawnItem(mod.ItemType("StatueOldItem"));
                                break;
                            case 39:
                                player.QuickSpawnItem(mod.ItemType("StatueYoungItem"));
                                break;
                            case 40:
                                player.QuickSpawnItem(mod.ItemType("StatueStopItem"));
                                break;
                                */
                        }
                        break;
                    }
                case 3:
                    {
                        {
                            switch (Main.rand.Next(17))
                            {
                                case 0:
                                    player.QuickSpawnItem(mod.ItemType("PaintingSlimeItem"));
                                    break;
                                case 1:
                                    player.QuickSpawnItem(mod.ItemType("PaintingEyeItem"));
                                    break;
                                case 2:
                                    player.QuickSpawnItem(mod.ItemType("PaintingEaterItem"));
                                    break;
                                case 3:
                                    player.QuickSpawnItem(mod.ItemType("PaintingBrainItem"));
                                    break;
                                case 4:
                                    player.QuickSpawnItem(mod.ItemType("PaintingBeeItem"));
                                    break;
                                case 5:
                                    player.QuickSpawnItem(mod.ItemType("PaintingSkeleItem"));
                                    break;
                                case 6:
                                    player.QuickSpawnItem(mod.ItemType("PaintingFleshItem"));
                                    break;
                                case 7:
                                    player.QuickSpawnItem(mod.ItemType("PaintingQSlimeItem"));
                                    break;
                                case 8:
                                    player.QuickSpawnItem(mod.ItemType("PaintingRetItem"));
                                    break;
                                case 9:
                                    player.QuickSpawnItem(mod.ItemType("PaintingSpazItem"));
                                    break;
                                case 10:
                                    player.QuickSpawnItem(mod.ItemType("PaintingDestItem"));
                                    break;
                                case 11:
                                    player.QuickSpawnItem(mod.ItemType("PaintingPrimeItem"));
                                    break;
                                case 12:
                                    player.QuickSpawnItem(mod.ItemType("PaintingPlantItem"));
                                    break;
                                case 13:
                                    player.QuickSpawnItem(mod.ItemType("PaintingGolemItem"));
                                    break;
                                case 14:
                                    player.QuickSpawnItem(mod.ItemType("PaintingLightItem"));
                                    break;
                                case 15:
                                    player.QuickSpawnItem(mod.ItemType("PaintingDukeItem"));
                                    break;
                                case 16:
                                    player.QuickSpawnItem(mod.ItemType("PaintingCultItem"));
                                    break;
                                case 17:
                                    player.QuickSpawnItem(mod.ItemType("PaintingMoonItem"));
                                    break;
                                    /* oh lord it is going to be five years before even one of these is used oh heavens
                                case 18:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 19:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 20:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 21:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 22:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 23:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 24:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 25:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 26:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 27:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 28:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 29:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 30:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 31:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 32:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 33:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 34:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 35:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 36:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 37:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 38:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 39:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 40:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                case 41:
                                    player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                    break;
                                    */
                            }
                            break;
                        }
                    }
                case 4:
                    {
                        {
                            switch (Main.rand.Next())
                            {
                                case 0:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Slime"));
                                    break;
                                case 1:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Eye"));
                                    break;
                                case 2:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Eater"));
                                    break;
                                case 3:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Brain"));
                                    break;
                                case 4:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Bee"));
                                    break;
                                case 5:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Skele"));
                                    break;
                                case 6:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Flesh"));
                                    break;
                                case 7:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_QSlime"));
                                    break;
                                case 8:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Mech"));
                                    break;
                                case 9:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Plant"));
                                    break;
                                case 10:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Golem"));
                                    break;
                                case 11:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Light"));
                                    break;
                                case 12:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Duke"));
                                    break;
                                case 13:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Cult"));
                                    break;
                                case 14:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Moon"));
                                    break;
                                    /*
                                case 15:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Cat"));
                                    break;
                                case 16:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Spider"));
                                    break;
                                case 17:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Crystal"));
                                    break;
                                case 18:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Snake"));
                                    break;
                                case 19:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Girl"));
                                    break;
                                case 20:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Cold"));
                                    break;
                                case 21:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Bird"));
                                    break;
                                case 22:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Ass"));
                                    break;
                                case 23:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Goat"));
                                    break;
                                case 24:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Fire"));
                                    break;
                                case 25:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Water"));
                                    break;
                                case 26:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Witch"));
                                    break;
                                case 27:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Squid"));
                                    break;
                                case 28:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Ball"));
                                    break;
                                case 29:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_God"));
                                    break;
                                case 30:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Boy"));
                                    break;
                                case 31:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Sword"));
                                    break;
                                case 32:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Fox"));
                                    break;
                                case 33:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Book"));
                                    break;
                                case 34:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Hero"));
                                    break;
                                case 35:
                                    player.QuickSpawnItem(mod.ItemType("LoreBook_Stop"));
                                    break;
                                    */
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        switch (Main.rand.Next(7))
                        {
                            case 0:
                                player.QuickSpawnItem(ItemID.MusicBoxBoss1);
                                break;
                            case 1:
                                player.QuickSpawnItem(ItemID.MusicBoxBoss2);
                                break;
                            case 2:
                                player.QuickSpawnItem(ItemID.MusicBoxBoss3);
                                break;
                            case 3:
                                player.QuickSpawnItem(ItemID.MusicBoxBoss4);
                                break;
                            case 4:
                                player.QuickSpawnItem(ItemID.MusicBoxBoss5);
                                break;
                            case 5:
                                player.QuickSpawnItem(ItemID.MusicBoxPlantera);
                                break;
                            case 6:
                                player.QuickSpawnItem(ItemID.MusicBoxLunarBoss);
                                break;
                                /*
                            case 7:
                                player.QuickSpawnItem(ItemID.MusicBoxQueenSlime);
                                break;
                            case 8:
                                player.QuickSpawnItem(ItemID.MusicBoxEmpressOfLight);
                                break;
                            case 9:
                                player.QuickSpawnItem(ItemID.MusicBoxDukeFishron);
                                break;
                                */
                        }
                        break;
                    }
            }
            if (Main.expertMode)
            {
                switch (Main.rand.Next(6))
                {
                    case 0:
                        {
                            switch (Main.rand.Next(17))
                            {
                                case 0:
                                    player.QuickSpawnItem(ItemID.KingSlimeMask);
                                    break;
                                case 1:
                                    player.QuickSpawnItem(ItemID.EyeMask);
                                    break;
                                case 2:
                                    player.QuickSpawnItem(ItemID.EaterMask);
                                    break;
                                case 3:
                                    player.QuickSpawnItem(ItemID.BrainMask);
                                    break;
                                case 4:
                                    player.QuickSpawnItem(ItemID.BeeMask);
                                    break;
                                case 5:
                                    player.QuickSpawnItem(ItemID.SkeletronMask);
                                    break;
                                case 6:
                                    player.QuickSpawnItem(ItemID.FleshMask);
                                    break;
                                case 7:
                                    player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                    Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                    break;
                                /*
                            case 7:
                                player.QuickSpawnItem(ItemID.QueenSlimeMask);
                                break;
                                */
                                case 8:
                                    player.QuickSpawnItem(ItemID.TwinMask);
                                    break;
                                case 9:
                                    player.QuickSpawnItem(ItemID.DestroyerMask);
                                    break;
                                case 10:
                                    player.QuickSpawnItem(ItemID.SkeletronPrimeMask);
                                    break;
                                case 11:
                                    player.QuickSpawnItem(ItemID.PlanteraMask);
                                    break;
                                case 12:
                                    player.QuickSpawnItem(ItemID.GolemMask);
                                    break;
                                case 13:
                                    player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                    Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                    break;
                                /*
                            case 13:
                                player.QuickSpawnItem(ItemID.FairyQueenMask);
                                break;
                                */
                                case 14:
                                    player.QuickSpawnItem(ItemID.DukeFishronMask);
                                    break;
                                case 15:
                                    player.QuickSpawnItem(ItemID.BossMaskCultist);
                                    break;
                                case 16:
                                    player.QuickSpawnItem(ItemID.BossMaskMoonlord);
                                    break;
                                    /* oh lord it is going to be five years before even one of these is used oh heavens
                                case 17:
                                    player.QuickSpawnItem(mod.ItemType("MaskCat"));
                                    break;
                                case 18:
                                    player.QuickSpawnItem(mod.ItemType("MaskSpider"));
                                    break;
                                case 19:
                                    player.QuickSpawnItem(mod.ItemType("MaskCrystal"));
                                    break;
                                case 20:
                                    player.QuickSpawnItem(mod.ItemType("MaskSnake"));
                                    break;
                                case 21:
                                    player.QuickSpawnItem(mod.ItemType("MaskGirl"));
                                    break;
                                case 22:
                                    player.QuickSpawnItem(mod.ItemType("MaskCold"));
                                    break;
                                case 23:
                                    player.QuickSpawnItem(mod.ItemType("MaskBird"));
                                    break;
                                case 24:
                                    player.QuickSpawnItem(mod.ItemType("MaskAss"));
                                    break;
                                case 25:
                                    player.QuickSpawnItem(mod.ItemType("MaskAsgore"));
                                    break;
                                case 26:
                                    player.QuickSpawnItem(mod.ItemType("MaskToriel"));
                                    break;
                                case 27:
                                    player.QuickSpawnItem(mod.ItemType("MaskFire"));
                                    break;
                                case 28:
                                    player.QuickSpawnItem(mod.ItemType("MaskWater"));
                                    break;
                                case 29:
                                    player.QuickSpawnItem(mod.ItemType("MaskWitch"));
                                    break;
                                case 30:
                                    player.QuickSpawnItem(mod.ItemType("MaskSquid"));
                                    break;
                                case 31:
                                    player.QuickSpawnItem(mod.ItemType("MaskBall"));
                                    break;
                                case 32:
                                    player.QuickSpawnItem(mod.ItemType("MaskGod"));
                                    break;
                                case 33:
                                    player.QuickSpawnItem(mod.ItemType("MaskBoy"));
                                    break;
                                case 34:
                                    player.QuickSpawnItem(mod.ItemType("MaskSword"));
                                    break;
                                case 35:
                                    player.QuickSpawnItem(mod.ItemType("MaskFox"));
                                    break;
                                case 36:
                                    player.QuickSpawnItem(mod.ItemType("MaskBlood"));
                                    break;
                                case 37:
                                    player.QuickSpawnItem(mod.ItemType("MaskBook"));
                                    break;
                                case 38:
                                    player.QuickSpawnItem(mod.ItemType("MaskOld"));
                                    break;
                                case 39:
                                    player.QuickSpawnItem(mod.ItemType("MaskYoung"));
                                    break;
                                case 40:
                                    player.QuickSpawnItem(mod.ItemType("MaskStop"));
                                    break;
                                    */
                            }
                            break;
                        }
                    case 1:
                        {
                            switch (Main.rand.Next(17))
                            {
                                case 0:
                                    player.QuickSpawnItem(ItemID.KingSlimeTrophy);
                                    break;
                                case 1:
                                    player.QuickSpawnItem(ItemID.EyeofCthulhuTrophy);
                                    break;
                                case 2:
                                    player.QuickSpawnItem(ItemID.EaterofWorldsTrophy);
                                    break;
                                case 3:
                                    player.QuickSpawnItem(ItemID.BrainofCthulhuTrophy);
                                    break;
                                case 4:
                                    player.QuickSpawnItem(ItemID.QueenBeeTrophy);
                                    break;
                                case 5:
                                    player.QuickSpawnItem(ItemID.SharkteethTrophy);
                                    break;
                                case 6:
                                    player.QuickSpawnItem(ItemID.WallofFleshTrophy);
                                    break;
                                case 7:
                                    player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                    Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                    break;
                                /*
                            case 7:
                                player.QuickSpawnItem(ItemID.QueenSlimeTrophy);
                                break;
                                */
                                case 8:
                                    player.QuickSpawnItem(ItemID.SpazmatismTrophy);
                                    break;
                                case 9:
                                    player.QuickSpawnItem(ItemID.DestroyerTrophy);
                                    break;
                                case 10:
                                    player.QuickSpawnItem(ItemID.SkeletronPrimeTrophy);
                                    break;
                                case 11:
                                    player.QuickSpawnItem(ItemID.PlanteraTrophy);
                                    break;
                                case 12:
                                    player.QuickSpawnItem(ItemID.GolemMask);
                                    break;
                                case 13:
                                    player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                    Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                    break;
                                /*
                            case 13:
                                player.QuickSpawnItem(ItemID.FairyQueenMask);
                                break;
                                */
                                case 14:
                                    player.QuickSpawnItem(ItemID.DukeFishronMask);
                                    break;
                                case 15:
                                    player.QuickSpawnItem(ItemID.BossMaskCultist);
                                    break;
                                case 16:
                                    player.QuickSpawnItem(ItemID.BossMaskMoonlord);
                                    break;
                                    /* oh lord it is going to be five years before even one of these is used oh heavens
                                case 17:
                                    player.QuickSpawnItem(mod.ItemType("MaskCat"));
                                    break;
                                case 18:
                                    player.QuickSpawnItem(mod.ItemType("MaskSpider"));
                                    break;
                                case 19:
                                    player.QuickSpawnItem(mod.ItemType("MaskCrystal"));
                                    break;
                                case 20:
                                    player.QuickSpawnItem(mod.ItemType("MaskSnake"));
                                    break;
                                case 21:
                                    player.QuickSpawnItem(mod.ItemType("MaskGirl"));
                                    break;
                                case 22:
                                    player.QuickSpawnItem(mod.ItemType("MaskCold"));
                                    break;
                                case 23:
                                    player.QuickSpawnItem(mod.ItemType("MaskBird"));
                                    break;
                                case 24:
                                    player.QuickSpawnItem(mod.ItemType("MaskAss"));
                                    break;
                                case 25:
                                    player.QuickSpawnItem(mod.ItemType("MaskAsgore"));
                                    break;
                                case 26:
                                    player.QuickSpawnItem(mod.ItemType("MaskToriel"));
                                    break;
                                case 27:
                                    player.QuickSpawnItem(mod.ItemType("MaskFire"));
                                    break;
                                case 28:
                                    player.QuickSpawnItem(mod.ItemType("MaskWater"));
                                    break;
                                case 29:
                                    player.QuickSpawnItem(mod.ItemType("MaskWitch"));
                                    break;
                                case 30:
                                    player.QuickSpawnItem(mod.ItemType("MaskSquid"));
                                    break;
                                case 31:
                                    player.QuickSpawnItem(mod.ItemType("MaskBall"));
                                    break;
                                case 32:
                                    player.QuickSpawnItem(mod.ItemType("MaskGod"));
                                    break;
                                case 33:
                                    player.QuickSpawnItem(mod.ItemType("MaskBoy"));
                                    break;
                                case 34:
                                    player.QuickSpawnItem(mod.ItemType("MaskSword"));
                                    break;
                                case 35:
                                    player.QuickSpawnItem(mod.ItemType("MaskFox"));
                                    break;
                                case 36:
                                    player.QuickSpawnItem(mod.ItemType("MaskBlood"));
                                    break;
                                case 37:
                                    player.QuickSpawnItem(mod.ItemType("MaskBook"));
                                    break;
                                case 38:
                                    player.QuickSpawnItem(mod.ItemType("MaskOld"));
                                    break;
                                case 39:
                                    player.QuickSpawnItem(mod.ItemType("MaskYoung"));
                                    break;
                                case 40:
                                    player.QuickSpawnItem(mod.ItemType("MaskStop"));
                                    break;
                                    */
                            }
                            break;
                        }
                    case 2:
                        {
                            switch (Main.rand.Next(17))
                            {
                                case 0:
                                    player.QuickSpawnItem(mod.ItemType("StatueSlimeItem"));
                                    break;
                                case 1:
                                    player.QuickSpawnItem(mod.ItemType("StatueEyeItem"));
                                    break;
                                case 2:
                                    player.QuickSpawnItem(mod.ItemType("StatueEaterItem"));
                                    break;
                                case 3:
                                    player.QuickSpawnItem(mod.ItemType("StatueBrainItem"));
                                    break;
                                case 4:
                                    player.QuickSpawnItem(mod.ItemType("StatueBeeItem"));
                                    break;
                                case 5:
                                    player.QuickSpawnItem(mod.ItemType("StatueSkeleItem"));
                                    break;
                                case 6:
                                    player.QuickSpawnItem(mod.ItemType("StatueFleshItem"));
                                    break;
                                case 7:
                                    player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                    Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                    break;
                                /*
                            case 7:
                                player.QuickSpawnItem(mod.ItemType("StatueQSlimeItem"));
                                break;
                                */
                                case 8:
                                    player.QuickSpawnItem(mod.ItemType("StatueTwinItem"));
                                    break;
                                case 9:
                                    player.QuickSpawnItem(mod.ItemType("StatueDestItem"));
                                    break;
                                case 10:
                                    player.QuickSpawnItem(mod.ItemType("StatuePrimeItem"));
                                    break;
                                case 11:
                                    player.QuickSpawnItem(mod.ItemType("StatuePlantItem"));
                                    break;
                                case 12:
                                    player.QuickSpawnItem(mod.ItemType("StatueGolemItem"));
                                    break;
                                case 13:
                                    player.QuickSpawnItem(ModContent.ItemType<Collector_Bag>());
                                    Main.NewText("Unlucky! If you were on 1.4 you would've gotten something! Try again.", 0, 0, 0);
                                    break;
                                /*
                            case 13:
                                player.QuickSpawnItem(mod.ItemType("StatueLightItem"));
                                break;
                                */
                                case 14:
                                    player.QuickSpawnItem(mod.ItemType("StatueDukeItem"));
                                    break;
                                case 15:
                                    player.QuickSpawnItem(mod.ItemType("StatueCultItem"));
                                    break;
                                case 16:
                                    player.QuickSpawnItem(mod.ItemType("StatueMoonItem"));
                                    break;
                                    /* oh lord it is going to be five years before even one of these is used oh heavens
                                case 17:
                                    player.QuickSpawnItem(mod.ItemType("StatueCatItem"));
                                    break;
                                case 18:
                                    player.QuickSpawnItem(mod.ItemType("StatueSpiderItem"));
                                    break;
                                case 19:
                                    player.QuickSpawnItem(mod.ItemType("StatueCrystalItem"));
                                    break;
                                case 20:
                                    player.QuickSpawnItem(mod.ItemType("StatueSnakeItem"));
                                    break;
                                case 21:
                                    player.QuickSpawnItem(mod.ItemType("StatueGirlItem"));
                                    break;
                                case 22:
                                    player.QuickSpawnItem(mod.ItemType("StatueColdItem"));
                                    break;
                                case 23:
                                    player.QuickSpawnItem(mod.ItemType("StatueBirdItem"));
                                    break;
                                case 24:
                                    player.QuickSpawnItem(mod.ItemType("StatueAssItem"));
                                    break;
                                case 25:
                                    player.QuickSpawnItem(mod.ItemType("StatueAsgoreItem"));
                                    break;
                                case 26:
                                    player.QuickSpawnItem(mod.ItemType("StatueTorielItem"));
                                    break;
                                case 27:
                                    player.QuickSpawnItem(mod.ItemType("StatueFireItem"));
                                    break;
                                case 28:
                                    player.QuickSpawnItem(mod.ItemType("StatueWaterItem"));
                                    break;
                                case 29:
                                    player.QuickSpawnItem(mod.ItemType("StatueWitchItem"));
                                    break;
                                case 30:
                                    player.QuickSpawnItem(mod.ItemType("StatueSquidItem"));
                                    break;
                                case 31:
                                    player.QuickSpawnItem(mod.ItemType("StatueBallItem"));
                                    break;
                                case 32:
                                    player.QuickSpawnItem(mod.ItemType("StatueGodItem"));
                                    break;
                                case 33:
                                    player.QuickSpawnItem(mod.ItemType("StatueBoyItem"));
                                    break;
                                case 34:
                                    player.QuickSpawnItem(mod.ItemType("StatueSwordItem"));
                                    break;
                                case 35:
                                    player.QuickSpawnItem(mod.ItemType("StatueFoxItem"));
                                    break;
                                case 36:
                                    player.QuickSpawnItem(mod.ItemType("StatueBloodItem"));
                                    break;
                                case 37:
                                    player.QuickSpawnItem(mod.ItemType("StatueBookItem"));
                                    break;
                                case 38:
                                    player.QuickSpawnItem(mod.ItemType("StatueOldItem"));
                                    break;
                                case 39:
                                    player.QuickSpawnItem(mod.ItemType("StatueYoungItem"));
                                    break;
                                case 40:
                                    player.QuickSpawnItem(mod.ItemType("StatueStopItem"));
                                    break;
                                    */
                            }
                            break;
                        }
                    case 3:
                        {
                            {
                                switch (Main.rand.Next(17))
                                {
                                    case 0:
                                        player.QuickSpawnItem(mod.ItemType("PaintingSlimeItem"));
                                        break;
                                    case 1:
                                        player.QuickSpawnItem(mod.ItemType("PaintingEyeItem"));
                                        break;
                                    case 2:
                                        player.QuickSpawnItem(mod.ItemType("PaintingEaterItem"));
                                        break;
                                    case 3:
                                        player.QuickSpawnItem(mod.ItemType("PaintingBrainItem"));
                                        break;
                                    case 4:
                                        player.QuickSpawnItem(mod.ItemType("PaintingBeeItem"));
                                        break;
                                    case 5:
                                        player.QuickSpawnItem(mod.ItemType("PaintingSkeleItem"));
                                        break;
                                    case 6:
                                        player.QuickSpawnItem(mod.ItemType("PaintingFleshItem"));
                                        break;
                                    case 7:
                                        player.QuickSpawnItem(mod.ItemType("PaintingQSlimeItem"));
                                        break;
                                    case 8:
                                        player.QuickSpawnItem(mod.ItemType("PaintingRetItem"));
                                        break;
                                    case 9:
                                        player.QuickSpawnItem(mod.ItemType("PaintingSpazItem"));
                                        break;
                                    case 10:
                                        player.QuickSpawnItem(mod.ItemType("PaintingDestItem"));
                                        break;
                                    case 11:
                                        player.QuickSpawnItem(mod.ItemType("PaintingPrimeItem"));
                                        break;
                                    case 12:
                                        player.QuickSpawnItem(mod.ItemType("PaintingPlantItem"));
                                        break;
                                    case 13:
                                        player.QuickSpawnItem(mod.ItemType("PaintingGolemItem"));
                                        break;
                                    case 14:
                                        player.QuickSpawnItem(mod.ItemType("PaintingLightItem"));
                                        break;
                                    case 15:
                                        player.QuickSpawnItem(mod.ItemType("PaintingDukeItem"));
                                        break;
                                    case 16:
                                        player.QuickSpawnItem(mod.ItemType("PaintingCultItem"));
                                        break;
                                    case 17:
                                        player.QuickSpawnItem(mod.ItemType("PaintingMoonItem"));
                                        break;
                                        /* oh lord it is going to be five years before even one of these is used oh heavens
                                    case 18:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 19:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 20:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 21:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 22:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 23:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 24:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 25:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 26:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 27:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 28:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 29:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 30:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 31:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 32:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 33:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 34:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 35:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 36:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 37:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 38:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 39:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 40:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                    case 41:
                                        player.QuickSpawnItem(mod.ItemType("PaintingItem"));
                                        break;
                                        */
                                }
                                break;
                            }
                        }
                    case 4:
                        {
                            {
                                switch (Main.rand.Next())
                                {
                                    case 0:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Slime"));
                                        break;
                                    case 1:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Eye"));
                                        break;
                                    case 2:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Eater"));
                                        break;
                                    case 3:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Brain"));
                                        break;
                                    case 4:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Bee"));
                                        break;
                                    case 5:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Skele"));
                                        break;
                                    case 6:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Flesh"));
                                        break;
                                    case 7:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_QSlime"));
                                        break;
                                    case 8:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Mech"));
                                        break;
                                    case 9:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Plant"));
                                        break;
                                    case 10:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Golem"));
                                        break;
                                    case 11:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Light"));
                                        break;
                                    case 12:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Duke"));
                                        break;
                                    case 13:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Cult"));
                                        break;
                                    case 14:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Moon"));
                                        break;
                                        /*
                                    case 15:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Cat"));
                                        break;
                                    case 16:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Spider"));
                                        break;
                                    case 17:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Crystal"));
                                        break;
                                    case 18:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Snake"));
                                        break;
                                    case 19:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Girl"));
                                        break;
                                    case 20:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Cold"));
                                        break;
                                    case 21:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Bird"));
                                        break;
                                    case 22:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Ass"));
                                        break;
                                    case 23:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Goat"));
                                        break;
                                    case 24:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Fire"));
                                        break;
                                    case 25:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Water"));
                                        break;
                                    case 26:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Witch"));
                                        break;
                                    case 27:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Squid"));
                                        break;
                                    case 28:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Ball"));
                                        break;
                                    case 29:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_God"));
                                        break;
                                    case 30:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Boy"));
                                        break;
                                    case 31:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Sword"));
                                        break;
                                    case 32:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Fox"));
                                        break;
                                    case 33:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Book"));
                                        break;
                                    case 34:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Hero"));
                                        break;
                                    case 35:
                                        player.QuickSpawnItem(mod.ItemType("LoreBook_Stop"));
                                        break;
                                        */
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            {
                                switch (Main.rand.Next(7))
                                {
                                    case 0:
                                        player.QuickSpawnItem(ItemID.MusicBoxBoss1);
                                        break;
                                    case 1:
                                        player.QuickSpawnItem(ItemID.MusicBoxBoss2);
                                        break;
                                    case 2:
                                        player.QuickSpawnItem(ItemID.MusicBoxBoss3);
                                        break;
                                    case 3:
                                        player.QuickSpawnItem(ItemID.MusicBoxBoss4);
                                        break;
                                    case 4:
                                        player.QuickSpawnItem(ItemID.MusicBoxBoss5);
                                        break;
                                    case 5:
                                        player.QuickSpawnItem(ItemID.MusicBoxPlantera);
                                        break;
                                    case 6:
                                        player.QuickSpawnItem(ItemID.MusicBoxLunarBoss);
                                        break;
                                        /*
                                    case 7:
                                        player.QuickSpawnItem(ItemID.MusicBoxQueenSlime);
                                        break;
                                    case 8:
                                        player.QuickSpawnItem(ItemID.MusicBoxEmpressOfLight);
                                        break;
                                    case 9:
                                        player.QuickSpawnItem(ItemID.MusicBoxDukeFishron);
                                        break;
                                        */
                                }
                            }
                            break;
                        }
                }
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Bossmatter>(), 30);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
        }
    }
}