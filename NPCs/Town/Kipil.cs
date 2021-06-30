using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Cleave.NPCs.Town.Images
{
    // [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
    [AutoloadHead]
    public class Kipil : ModNPC
    {
        public override string Texture => "Cleave/NPCs/Town/Images/Kipil";

        public override string[] AltTextures => new[] { "Cleave/NPCs/Town/Images/Kipil_Alt" };

        public override bool Autoload(ref string name)
        {
            name = "Kipil Wizard";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kipil");
            Main.npcFrameCount[npc.type] = 23;
            NPCID.Sets.ExtraFramesCount[npc.type] = 0;
            NPCID.Sets.AttackFrameCount[npc.type] = 2;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] -= 16;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 20;
            npc.height = 32;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Wizard;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (NPC.AnyNPCs(NPCID.Guide) == true)
            {
                return true;
            }
            return false;
        }
        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(1))
            {
                default:
                    return "Ailks";
            }
        }
        public override string GetChat()
        {
            if (!Main.dayTime && Main.rand.NextBool(10))
            {
                if (Main.rand.NextBool(3))
                {
                    return "Zombies coming up at night, I feel like I`ve seen that somewhere else.";
                }
                else if (Main.rand.NextBool(2))
                {
                    return "I don`t think Demon Eyes are actually related to Demons. Just a hunch.";
                }
                else
                {
                    return "The Guide says it’s dangerous at night, but that`s just because he only has that bow to defend himself and he opens doors for monsters.";
                }
            }
            if (Main.hardMode && Main.rand.NextBool(10))
            {
                if (Main.rand.NextBool(4))
                {
                    return "Oh goodie soul farming.";
                }
                else if (Main.rand.NextBool(3))
                {
                    return "You better not let a Wraith come kill me.";
                }
                else if (Main.rand.NextBool(2))
                {
                    return "So I know that most of those bulbs in the jungle just summon the plant with the band name, but a few look a bit familiar to me... weird.";
                }
                else
                {
                    return "Those Wyverns are neat. They actually look similar to the ones in Kiplinjar, and they both shouldn`t be called Wyverns.";
                }
            }
            if (NPC.downedMoonlord && Main.rand.NextBool(10))
            {
                if (Main.rand.NextBool(12))
                {
                    if (ModLoader.GetMod("CalamityMod") != null)
                    {
                        return "The only good thing that happened is now that dragon clone is out and about. I might catch it after you fight it and make it my pet.";
                    }
                }
                if (Main.rand.NextBool(11))
                {
                    if (ModLoader.GetMod("ThoriumMod") != null)
                    {
                        return "The elements are awakening, wait, that’s not right.";
                    }
                }
                if (Main.rand.NextBool(10))
                {
                    if (ModLoader.GetMod("SacredTools") != null)
                    {
                        return "I`ve been having insomnia lately, do you know anyone who could help with that?";
                    }
                }
                if (Main.rand.NextBool(9))
                {
                    if (ModLoader.GetMod("Redemption") != null)
                    {
                        return "I hear that Girus chick is gettin particularly antsy about you. You also might wanna do something about that infection, I’m 2 shades greener since I came here.";
                    }
                }
                if (Main.rand.NextBool(8))
                {
                    if (ModLoader.GetMod("AAMod") != null)
                    {
                        return "I hear some people who you defeated before want a rematch. In Kiplinjar, we usually quit after the first go around.";
                    }
                }
                if (Main.rand.NextBool(7))
                {
                    if (ModLoader.GetMod("ElementsAwoken") != null)
                    {
                        return "I bet you could get a use out of those Infinity Crystal things now with that luminous metal.";
                    }
                }
                if (Main.rand.NextBool(6))
                {
                    if (ModLoader.GetMod("pinkymod") != null)
                    {
                        return "The mind is an interesting thing. Memories can be twisted, warped and completely obliterated in an instant. What was I saying again?";
                    }
                }
                if (Main.rand.NextBool(5))
                {
                    if (ModLoader.GetMod("FargowiltasSouls") != null)
                    {
                        return "I hear the areas where biomes are purest are teeming with strong presences. Also those amalgamations seem to be willing to fight now.";
                    }
                }
                if (Main.rand.NextBool(4))
                {
                    if (ModLoader.GetMod("Ultranium") != null)
                    {
                        return "Careful after you kill the guardians of nature and Hell, something dreadful is sure to happen after.";
                    }
                }
                if (Main.rand.NextBool(3))
                {
                    if (ModLoader.GetMod("SGAmod") != null)
                    {
                        return "Does reality seem... buggy to you?";
                    }

                }
                if (Main.rand.NextBool(2))
                {
                    return "Did you see the tentacles on that guy? Sheesh, on god, respectfully.";
                }
                else
                {
                    return "Now’s when all the edgy bosses rear their heads. Quite literally for one you’ll see in a while.";
                }
            }
            int guide = NPC.FindFirstNPC(NPCID.Guide);
            if (guide >= 0 && Main.rand.NextBool(26))
            {
                return "Haven`t you ever questioned why " + Main.npc[guide].GivenName + " knows so much? Even if those rumors I`ve heard are true, that doesn`t add up.";
            }
            int merchant = NPC.FindFirstNPC(NPCID.Merchant);
            if (merchant >= 0 && Main.rand.NextBool(25))
            {
                return "That liar " + Main.npc[merchant].GivenName + " doesn`t even sell dirt blocks.";
            }
            int nurse = NPC.FindFirstNPC(NPCID.Nurse);
            if (nurse >= 0 && Main.rand.NextBool(24))
            {
                return "Sometimes I forget " + Main.npc[nurse].GivenName + " exists. Not sure why.";
            }
            int armsDealer = NPC.FindFirstNPC(NPCID.ArmsDealer);
            if (armsDealer >= 0 && Main.rand.NextBool(23))
            {
                return "I`d like " + Main.npc[armsDealer].GivenName + " a lot more if it weren`t for the fact that he only sells `real` guns. No respect for magic guns.";
            }
            int dryad = NPC.FindFirstNPC(NPCID.Dryad);
            if (dryad >= 0 && Main.rand.NextBool(22))
            {
                return Main.npc[dryad].GivenName + " is one of the few people to impress me around here. That Dirt Rod she has can do some impressive things, even without mana!";
            }
            int angler = NPC.FindFirstNPC(NPCID.Angler);
            if (angler >= 0 && Main.rand.NextBool(21))
            {
                return Main.npc[angler].GivenName + " always complains about needing to cook his fish, yet he never cooks any or at least doesn`t give me any.";
            }
            int demolitionist = NPC.FindFirstNPC(NPCID.Demolitionist);
            if (demolitionist >= 0 && Main.rand.NextBool(20))
            {
                return "With " + Main.npc[demolitionist].GivenName + ", I have someone to perfect my explosion magic with.";
            }
            int stylist = NPC.FindFirstNPC(NPCID.Stylist);
            if (stylist >= 0 && Main.rand.NextBool(19))
            {
                return Main.npc[stylist].GivenName + " says my horns get in the way of my hair too much to cut it. Eventually she did break in and touch it up, I guess the hat hair was that bad.";
            }
            int dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
            if (dyeTrader >= 0 && Main.rand.NextBool(18))
            {
                return Main.npc[dyeTrader].GivenName + " doesn`t believe that I was able to color my robe myself. Someday I`ll take him to Kiplinjar and show him how easy it is there.";
            }
            int scamArtist = NPC.FindFirstNPC(NPCID.GoblinTinkerer);
            if (scamArtist >= 0 && Main.rand.NextBool(17))
            {
                return "Apparently " + Main.npc[scamArtist].GivenName + " is a major scam artist. I wouldn`t know, since I don`t have anything to be reforged.";
            }
            int painter = NPC.FindFirstNPC(NPCID.Painter);
            if (painter >= 0 && Main.rand.NextBool(16))
            {
                return Main.npc[painter].GivenName + " said he`s accepting commissions, I think I`ll have him paint a few things. Maybe check with him later to see if he`s selling them. Or you could maybe help him?”";
            }
            int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
            if (partyGirl >= 0 && Main.rand.NextBool(15))
            {
                return Main.npc[partyGirl].GivenName + " certainty makes her presence known. Parties with her are way way different than anything on Kiplinjar.";
            }
            int tavernKeep = NPC.FindFirstNPC(NPCID.DD2Bartender);
            if (tavernKeep >= 0 && Main.rand.NextBool(14))
            {
                return "Here I was thinking my world was the only one leaking into this one, then " + Main.npc[tavernKeep].GivenName + " shows up.";
            }
            int witchDoctor = NPC.FindFirstNPC(NPCID.WitchDoctor);
            if (witchDoctor >= 0 && Main.rand.NextBool(13))
            {
                return "Out of all the different folks in Kiplinjar, I`ve never seen someone like " + Main.npc[witchDoctor].GivenName + ". He`s nice to talk to though, helps me practice talking in riddles.";
            }
            int clothier = NPC.FindFirstNPC(NPCID.Clothier);
            if (clothier >= 0 && Main.rand.NextBool(12))
            {
                return Main.npc[clothier].GivenName + " gives off a weird aura, but he helps me out when I need something other than robes to wear.";
            }
            int mechanic = NPC.FindFirstNPC(NPCID.Mechanic);
            if (mechanic >= 0 && Main.rand.NextBool(11))
            {
                return Main.npc[mechanic].GivenName + " often asks me to use lightning magic to power her machines. It’s enjoyable most times, but when they blow up not so much.";
            }
            int wizard = NPC.FindFirstNPC(NPCID.Wizard);
            if (wizard >= 0 && Main.rand.NextBool(10))
            {
                return "Now that`s what I`m talking about. " + Main.npc[wizard].GivenName + " actually understands me. He`s also pretty strong himself, so I recommend not letting him forget you`re his ally.";
            }
            int fungus = NPC.FindFirstNPC(NPCID.Truffle);
            if (fungus >= 0 && Main.rand.NextBool(9))
            {
                return "Do you know how hard it is to not make puns with " + Main.npc[fungus].GivenName + " around?";
            }
            int pirate = NPC.FindFirstNPC(NPCID.Pirate);
            if (pirate >= 0 && Main.rand.NextBool(8))
            {
                return Main.npc[pirate].GivenName + " mistook me for a mutated parrot once. I don`t blame him.";
            }
            int fake = NPC.FindFirstNPC(NPCID.SantaClaus);
            if (fake >= 0 && Main.rand.NextBool(7))
            {
                return "Us Kipils usually don’t celebrate this Christmas thing. I had a few human friends that did though. I wonder if " + Main.npc[fake].GivenName + " thinks I`m nice enough.";
            }
            int steamgunker = NPC.FindFirstNPC(NPCID.Steampunker);
            if (steamgunker >= 0 && Main.rand.NextBool(6))
            {
                return "That punk " + Main.npc[steamgunker].GivenName + " has come pretty close to making me think technology is just a different type of magic.";
            }
            int irs = NPC.FindFirstNPC(NPCID.TaxCollector);
            if (irs >= 0 && Main.rand.NextBool(5))
            {
                return Main.npc[irs].GivenName + " is just the type of person to throw water balloons at while his back is turned. You oughta try it sometimes, it`s a riot.";
            }
            int cyborg = NPC.FindFirstNPC(NPCID.Cyborg);
            if (cyborg >= 0 && Main.rand.NextBool(4))
            {
                return "I think " + Main.npc[cyborg].GivenName + " gets lonely sometimes, I heard not many people talk to him around here.";
            }
            switch (Main.rand.Next(10))
            {
                case 0:
                    return "Having a beak really sucks man.";
                case 1:
                    return "There aren`t enough tall mountains to glide off of in this world, and I`m not about to drink one of those `Gravitation Potions`.";
                case 2:
                    return "Remind me again why everything is block based?";
                case 3:
                    return "That`s one similarity to Kiplinjar; there’s slimes absolutely everywhere";
                case 4:
                    return "This is considered housing? The slums of the Underjar are better than this.";
                case 5:
                    return "Finally, I can tell people to go to Hell and mean it.";
                case 6:
                    return "Do you know how hard it is to be fashionable when you have so few pixels to work with? Oh wait, yes you do.";
                case 7:
                    return "You may think all I say are complaints, but this quote technically isn`t a complaint so not all of them are.";
                case 8:
                    return "Why do I sell summon items? Well occasionally watching you fight is fun. Except when you just shoot and run away. That`s boring. Don`t do that.";
                case 9:
                    return "Oh my goodness these sleeves are a nightmare, why did I make them this long... ugh.";
                default:
                    return "Did you want me to have some sort of “help” function? Just look at the Boss Checklist and craft the summon items, you`ll learn what you need to from the bosses themselves. Or read the wiki if you`re that desperate for a wall of text. I also hear that someone you might encounter later will sell you books, so if you`re patient you can get them legit.";
            }
        }
        public override void SetChatButtons(ref string button, ref string button2) => button = "Shop";
        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
                shop = true;
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SlimeCrown);
                shop.item[nextSlot].shopCustomPrice = 20000;
                nextSlot++;
            }
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SuspiciousLookingEye);
                shop.item[nextSlot].shopCustomPrice = 60000;
                nextSlot++;
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.WormFood);
                shop.item[nextSlot].shopCustomPrice = 100000;
                nextSlot++;
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BloodySpine);
                shop.item[nextSlot].shopCustomPrice = 100000;
                nextSlot++;
            }
            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Abeemination);
                shop.item[nextSlot].shopCustomPrice = 120000;
                nextSlot++;
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Skeletron_Summon"));
                shop.item[nextSlot].shopCustomPrice = 140000;
                nextSlot++;
            }
            if (Main.hardMode)
            { 
                shop.item[nextSlot].SetDefaults(mod.ItemType("Flesh_Summon"));
                shop.item[nextSlot].shopCustomPrice = 160000;
                nextSlot++;
            }
            if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye);
                shop.item[nextSlot].shopCustomPrice = 240000;
                nextSlot++;
            }
            if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm);
                shop.item[nextSlot].shopCustomPrice = 240000;
                nextSlot++;
            }
            if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull);
                shop.item[nextSlot].shopCustomPrice = 240000;
                nextSlot++;
            }
            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Plantera_Summon"));
                shop.item[nextSlot].shopCustomPrice = 300000;
                nextSlot++;
            }
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Golem_Summon"));
                shop.item[nextSlot].shopCustomPrice = 320000;
                nextSlot++;
            }
            if (NPC.downedFishron)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
                shop.item[nextSlot].shopCustomPrice = 500000;
                nextSlot++;
            }
            if (NPC.downedAncientCultist)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Lunatic_Summon"));

                shop.item[nextSlot].shopCustomPrice = 600000;
                nextSlot++;
            }
            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CelestialSigil);
                shop.item[nextSlot].shopCustomPrice = 1000000;
                nextSlot++;
            }
        }
        public override bool CanGoToStatue(bool toKingStatue)
        {
            return true;
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            if (Main.hardMode)
            {
                if (NPC.downedMoonlord)
                {
                    damage = 120;
                }
                else
                {
                    damage = 60;
                }
            }
            else
            {
                damage = 15;
            }
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 6;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            if (Main.hardMode)
            {
                if (NPC.downedMoonlord)
                {
                    projType = ProjectileID.RainbowRodBullet;
                }
                else
                {
                    projType = ProjectileID.Flamelash;
                }
            }
            else
            {
                projType = ProjectileID.MagicMissile;
            }
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 1f;
        }
    }
}