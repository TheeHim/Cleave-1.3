using Terraria;
using Terraria.ID;
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
            switch (Main.rand.Next(4))
            {
                case 0:
                    {
                        if (!Main.dayTime)
                        {
                            switch (Main.rand.Next(3))
                            {
                                case 0:
                                    return "Zombies coming up at night, I feel like I`ve seen that somewhere else.";
                                case 1:
                                    return "I don`t think Demon Eyes are actually related to Demons. Just a hunch.";
                                default:
                                    return "The Guide says it’s dangerous at night, but that`s just because he only has that bow to defend himself and he opens doors for monsters.";
                            }
                        }
                        else return "Sure is bright out. I much prefer the night.";
                    }
                case 1:
                    {
                        if (Main.hardMode)
                        {
                            switch (Main.rand.Next(4))
                            {
                                case 0:
                                    return "Oh goodie soul farming.";
                                case 1:
                                    return "You better not let a Wraith come kill me.";
                                case 2:
                                    return "So I know that most of those bulbs in the jungle just summon the plant with the band name, but a few look a bit familiar to me... weird.";
                                default:
                                    return "Those Wyverns are neat. They actually look similar to the ones in Kiplinjar, and they both shouldn`t be called Wyverns.";
                            }
                        }
                        else return "You ever feel like somethings being held back in this world? Like there`s power just balled up somewhere, waiting to be released?";
                    }
                case 2:
                    {
                        if (NPC.downedMoonlord)
                        {
                            switch (Main.rand.Next(11))
                            {
                                case 0:
                                    {
                                        if (ModLoader.GetMod("CalamityMod") != null)
                                        {
                                            return "The only good thing that happened is now that dragon clone is out and about. I might catch it after you fight it and make it my pet.";
                                        }
                                        else return "I like the balance that this world has. Though I feel like it`d be really easy to throw it off with one mere modification.";
                                    }
                                case 1:
                                    {
                                        if (ModLoader.GetMod("ThoriumMod") != null)
                                        {
                                            return "The elements are awakening, wait, that’s not right.";
                                        }
                                        else return "Ugh, whenever I try and get any sleep it feels like something comes around and eats my dreams. I can`t tell what it is though.";
                                    }
                                case 2:
                                    {
                                        if (ModLoader.GetMod("SacredTools") != null)
                                        {
                                            return "I`ve been having insomnia lately, do you know anyone who could help with that?";
                                        }
                                        else return "These terrible nightmares I`ve been having, surely there`s something causing this. Can you put a stop to it?";
                                    }
                                case 3:
                                    {
                                        if (ModLoader.GetMod("Redemption") != null)
                                        {
                                            return "I hear that Girus chick is gettin particularly antsy about you. You also might wanna do something about that infection, I’m 2 shades greener since I came here.";
                                        }
                                        else return "You`ve explored all the caves underground right? I feel like when I`m down there theres some sort of radiation, but I can`t find the source.";
                                    }
                                case 4:
                                    {
                                        if (ModLoader.GetMod("AAMod") != null)
                                        {
                                            return "I hear some people who you defeated before want a rematch. In Kiplinjar, we usually quit after the first go around.";
                                        }
                                        else return "I feel like terrible things are awake now, but I can`t identify any of them.";
                                    }
                                case 5:
                                    {
                                        if (ModLoader.GetMod("ElementsAwoken") != null)
                                        {
                                            return "I bet you could get a use out of those Infinity Crystal things now with that luminous metal.";
                                        }
                                        else return "Ok, the Wall of Flesh may be the core of the world, but what else in this land is actually alive? I feel like the forces of nature itself are alive and thriving.";
                                    }
                                case 6:
                                    {
                                        if (ModLoader.GetMod("pinkymod") != null)
                                        {
                                            return "The mind is an interesting thing. Memories can be twisted, warped and completely obliterated in an instant. What was I saying again?";
                                        }
                                        else return "No thoughts, head empty.";
                                    }
                                case 7:
                                    {
                                        if (ModLoader.GetMod("FargowiltasSouls") != null)
                                        {
                                            return "I hear the areas where biomes are purest are teeming with strong presences. Also those amalgamations seem to be willing to fight now.";
                                        }
                                        else return "Weird thought: What if all your previous big foes combined into one entity, and then moved into town. Wonder what would happen there.";
                                    }
                                case 8:
                                    {
                                        if (ModLoader.GetMod("Ultranium") != null)
                                        {
                                            return "Careful after you kill the guardians of nature and Hell, something dreadful is sure to happen after.";
                                        }
                                        else return "There`s no way you didn`t hear that dreadful roar last night, right? It wasn`t just me right?";
                                    }
                                case 9:
                                    {
                                        if (ModLoader.GetMod("SGAmod") != null)
                                        {
                                            return "Does reality seem... buggy to you?";
                                        }
                                        else return "I swear last night I saw a suit of armor start walking around and mumbling about their boss. Do you know anythign about that?";
                                    }
                                case 10:
                                    return "Did you see the tentacles on that guy? Sheesh, on god, respectfully.";
                                default:
                                    return "Now’s when all the edgy bosses rear their heads. Quite literally for one you’ll see in a while.";
                            }
                        }
                        else return null;
                    }
                case 3:
                    {
                        int guide = NPC.FindFirstNPC(NPCID.Guide);
                        int merchant = NPC.FindFirstNPC(NPCID.Merchant);
                        int nurse = NPC.FindFirstNPC(NPCID.Nurse);
                        int armsDealer = NPC.FindFirstNPC(NPCID.ArmsDealer);
                        int dryad = NPC.FindFirstNPC(NPCID.Dryad);
                        int angler = NPC.FindFirstNPC(NPCID.Angler);
                        int demolitionist = NPC.FindFirstNPC(NPCID.Demolitionist);
                        int stylist = NPC.FindFirstNPC(NPCID.Stylist);
                        int dyeTrader = NPC.FindFirstNPC(NPCID.DyeTrader);
                        int scamArtist = NPC.FindFirstNPC(NPCID.GoblinTinkerer);
                        int painter = NPC.FindFirstNPC(NPCID.Painter);
                        int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
                        int tavernKeep = NPC.FindFirstNPC(NPCID.DD2Bartender);
                        int witchDoctor = NPC.FindFirstNPC(NPCID.WitchDoctor);
                        int clothier = NPC.FindFirstNPC(NPCID.Clothier);
                        int mechanic = NPC.FindFirstNPC(NPCID.Mechanic);
                        int wizard = NPC.FindFirstNPC(NPCID.Wizard);
                        int fungus = NPC.FindFirstNPC(NPCID.Truffle);
                        int pirate = NPC.FindFirstNPC(NPCID.Pirate);
                        int fake = NPC.FindFirstNPC(NPCID.SantaClaus);
                        int steamgunker = NPC.FindFirstNPC(NPCID.Steampunker);
                        int irs = NPC.FindFirstNPC(NPCID.TaxCollector);
                        int cyborg = NPC.FindFirstNPC(NPCID.Cyborg);
                        switch (Main.rand.Next(22))
                        {
                            case 0:
                                {
                                    if (guide >= 0)
                                    {
                                        return "Haven`t you ever questioned why " + Main.npc[guide].GivenName + " knows so much? Even if those rumors I`ve heard are true, that doesn`t add up.";
                                    }
                                    else return "Isn`t there some sort of guide for this place? I have no idea what`s what around here, and you`re always off killing or mining.";
                                }
                            case 1:
                                {
                                    if (merchant >= 0)
                                    {
                                        return "That liar " + Main.npc[merchant].GivenName + " doesn`t even sell dirt blocks.";
                                    }
                                    else return "Do you know anywhere I can buy dirt blocks? They're a pain to dig up and are never dirty enough.";
                                }
                            case 2:
                                {
                                    if (nurse >= 0)
                                    {
                                        return "Sometimes I forget " + Main.npc[nurse].GivenName + " exists. Not sure why.";
                                    }
                                    else return "So, are you just gonna leave that massive wound on your face uncovered? Surely there`s a doctor around here.";
                                }
                            case 3:
                                {
                                    if (armsDealer >= 0)
                                    {
                                        return "I`d like " + Main.npc[armsDealer].GivenName + " a lot more if it weren`t for the fact that he only sells `real` guns. No respect for magic guns.";
                                    }
                                    else return "Swords and bows are great and all, and magic is easily the best, but surely you guys have firearms here too, right?";
                                }
                            case 4:
                                {
                                    if (dryad >= 0)
                                    {
                                        return Main.npc[dryad].GivenName + " is one of the few people to impress me around here. That Dirt Rod she has can do some impressive things, even without mana!";
                                    }
                                    else return "I heard rumors that there`s some chick roaming around with super strong nature magic. Think you can get her in town?";
                                }
                            case 5:
                                {
                                    if (angler >= 0)
                                    {
                                        return Main.npc[angler].GivenName + " always complains about needing to cook his fish, yet he never cooks any or at least doesn`t give me any.";
                                    }
                                    else return "With those big oceans at the edges of the world, surely there`s some master fisherman out there, right?";
                                }
                            case 6:
                                {
                                    if (demolitionist >= 0)
                                    {
                                        return "With " + Main.npc[demolitionist].GivenName + ", I have someone to perfect my explosion magic with.";
                                    }
                                    else return "This town has no bang! I'd start blowing things up myself, but I think that`d give a poor image of Kiplinjar.";
                                }
                            case 7:
                                {
                                    if (stylist >= 0)
                                    {
                                        return Main.npc[stylist].GivenName + " says my horns get in the way of my hair too much to cut it. Eventually she did break in and touch it up, I guess the hat hair was that bad.";
                                    }
                                    else return "Know any barbers? My hat hair is awful like you wouldn`t beleive.";
                                }
                            case 8:
                                {
                                    if (dyeTrader >= 0)
                                    {
                                        return Main.npc[dyeTrader].GivenName + " doesn`t believe that I was able to color my robe myself. Someday I`ll take him to Kiplinjar and show him how easy it is there.";
                                    }
                                    else return "My robes are loosing color and I have no idea how to use the flora here to make dye like I did at home. Do you know anyone who does?";
                                }
                            case 9:
                                {
                                    if (scamArtist >= 0)
                                    {
                                        return "Apparently " + Main.npc[scamArtist].GivenName + " is a major scam artist. I wouldn`t know, since I don`t have anything to be reforged.";
                                    }
                                    else return "I bet those goblins could be reasoned with if you try. Maybe even just one is friendly, we just haven`t found them yet.";
                                }
                            case 10:
                                {
                                    if (painter >= 0)
                                    {
                                        return Main.npc[painter].GivenName + " said he`s accepting commissions, I think I`ll have him paint a few things. Maybe check with him later to see if he`s selling them. Or you could maybe help him?”";
                                    }
                                    else return "Surely there`s an artist around here, yeah? I wanna see if I`ll get a better deal for a commission here than at home.";
                                }
                            case 11:
                                {
                                    if (partyGirl >= 0)
                                    {
                                        return Main.npc[partyGirl].GivenName + " certainty makes her presence known. Parties with her are way way different than anything on Kiplinjar.";
                                    }
                                    else return "Gee, it sure is boring around here. You know anyone who could liven it up?";
                                }
                            case 12:
                                {
                                    if (tavernKeep >= 0)
                                    {
                                        return "Here I was thinking my world was the only one leaking into this one, then " + Main.npc[tavernKeep].GivenName + " shows up.";
                                    }
                                    else return "You got any drinks around here? I guarantee they won`t be as strong as what we have in Kiplinjar, but I`d still like to try what you have here.";
                                }
                            case 13:
                                {
                                    if (witchDoctor >= 0)
                                    {
                                        return "Out of all the different folks in Kiplinjar, I`ve never seen someone like " + Main.npc[witchDoctor].GivenName + ". He`s nice to talk to though, helps me practice talking in riddles.";
                                    }
                                    else return "One time in the Jungle I saw a HUGE temple. I couldn`t get in, but I wonder if someone might come out eventually?";
                                }
                            case 14:
                                {
                                    if (clothier >= 0)
                                    {
                                        return Main.npc[clothier].GivenName + " gives off a weird aura, but he helps me out when I need something other than robes to wear.";
                                    }
                                    else return "I passed by the Dungeon before, what`s with that old dude? Think he might come into town some day?";
                                }
                            case 15:
                                {
                                    if (mechanic >= 0)
                                    {
                                        return Main.npc[mechanic].GivenName + " often asks me to use lightning magic to power her machines. It`s enjoyable most times, but when they blow up not so much.";
                                    }
                                    else return "This town doesn`t have enough tech in it. Might sound weird coming from me, but how else am I gonna catch on my Soap Operas?";
                                }
                            case 16:
                                {
                                    if (wizard >= 0)
                                    {
                                        return "Now that`s what I`m talking about. " + Main.npc[wizard].GivenName + " actually understands me. He`s also pretty strong himself, so I recommend not letting him forget you`re his ally.";
                                    }
                                    else return "Surely you have wizards here too right? I feel weird being the only one in town.";
                                }
                            case 17:
                                {
                                    if (fungus >= 0)
                                    {
                                        return "Do you know how hard it is to not make puns with " + Main.npc[fungus].GivenName + " around?";
                                    }
                                    else return "I feel like those Glowing Mushroom patches underground have more to offer than what a normal eye would see. Who knows, a mushroom might sprout legs and come walk into town.";
                                }
                            case 18:
                                {
                                    if (pirate >= 0)
                                    {
                                        return Main.npc[pirate].GivenName + " mistook me for a mutated parrot once. I don`t blame him.";
                                    }
                                    else return "Yar har. What? I`m practicing in case I ever need to talk to a pirate.";
                                }
                            case 19:
                                {
                                    if (fake >= 0)
                                    {
                                        return "Us Kipils usually don’t celebrate this Christmas thing. I had a few human friends that did though. I wonder if " + Main.npc[fake].GivenName + " thinks I`m nice enough.";
                                    }
                                    else return "In Kiplinjar, some people already have their Christmas decorations out. Don`t they know what time of year it is?";
                                }
                            case 20:
                                {
                                    if (steamgunker >= 0)
                                    {
                                        return "That punk " + Main.npc[steamgunker].GivenName + " has come pretty close to making me think technology is just a different type of magic.";
                                    }
                                    else return "Sometimes I try to fly by exploding the area under my feet. Surely there`s a more effective way to get up high, like with a jetpack or something?";
                                }
                            case 21:
                                {
                                    if (irs >= 0)
                                    {
                                        return Main.npc[irs].GivenName + " is just the type of person to throw water balloons at while his back is turned. You oughta try it sometimes, it`s a riot.";
                                    }
                                    else return "You run this town and don`t make anyone pay taxes or rent? Sick dude, thanks!";
                                }
                            default:
                                {
                                    if (cyborg >= 0)
                                    {
                                        return "I think " + Main.npc[cyborg].GivenName + " gets lonely sometimes, I heard not many people talk to him around here.";
                                    }
                                    else return "Robots are cool. They`re all over Kiplinjar, I was actually quite good friends with one of our guard robots at home. Any around here that you know of?";
                                }
                        }
                    }
                default:
                    {
                        switch (Main.rand.Next(10))
                        {
                            case 0:
                                return "Having a beak really sucks man.";
                            case 1:
                                return "There aren`t enough tall mountains to glide off of in this world, and I`m not about to drink one of those `Gravitation Potions`.";
                            case 2:
                                return "Remind me again why everything is block based?";
                            case 3:
                                return "That`s one similarity to Kiplinjar; there`s slimes absolutely everywhere";
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
            //Wormhole Disruptor
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SuspiciousLookingEye);
                shop.item[nextSlot].shopCustomPrice = 60000;
                nextSlot++;
            }
            //Delectable Insect
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
            //Cryline Caller
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Summon_Skele"));
                shop.item[nextSlot].shopCustomPrice = 140000;
                nextSlot++;
            }
            //Serpent Bait
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Summon_Flesh"));
                shop.item[nextSlot].shopCustomPrice = 160000;
                nextSlot++;
            }
            //Gelatin Crystal
            //Rune of Doom
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
            //Particuarly Cold Snow
            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Plantera_Summon"));
                shop.item[nextSlot].shopCustomPrice = 300000;
                nextSlot++;
            }
            //Sigil of the Avians
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Golem_Summon"));
                shop.item[nextSlot].shopCustomPrice = 320000;
                nextSlot++;
            }
            //Scarlet Crystal
            if (NPC.downedFishron)
            {
                shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
                shop.item[nextSlot].shopCustomPrice = 500000;
                nextSlot++;
            }
            //Goat Feed
            if (NPC.downedAncientCultist)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Lunatic_Summon"));

                shop.item[nextSlot].shopCustomPrice = 600000;
                nextSlot++;
            }
            //Infernal Coin
            if (NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ItemID.CelestialSigil);
                shop.item[nextSlot].shopCustomPrice = 1000000;
                nextSlot++;
            }
            /*
             * Crystal Heart
             * Hypercharged Pink Gel
             * Conglomerate Fish
             * Endcaller
             * Radiant Crystal
             * Cybernetic Sheath
             * Hand of Haltage
             */
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