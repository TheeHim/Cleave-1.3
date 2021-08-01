using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Effects;
using Cleave.BGs.Skies;
using Terraria.Graphics.Shaders;
using Terraria.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Cleave
{
    public class Cleave : Mod
    {
        public override void PostSetupContent()
        {
            Mod censusMod = ModLoader.GetMod("Census");
            if (censusMod != null)
            {
                censusMod.Call("TownNPCCondition", NPCType("Kipil Wizard"), "Defeat the King Slime");
            }
        }
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => "Any Lunar Fragment", new int[]
            {
        ItemID.FragmentSolar,
        ItemID.FragmentVortex,
        ItemID.FragmentNebula,
        ItemID.FragmentStardust
            });
            RecipeGroup.RegisterGroup("Cleave:LFragments", group);
            group = new RecipeGroup(() => "Any Tier 1 Gem", new int[]
            {
        ItemID.Amethyst,
        ItemID.Topaz
            });
            RecipeGroup.RegisterGroup("Cleave:Gem1", group);
            group = new RecipeGroup(() => "Any Tier 2 Gem", new int[]
            {
        ItemID.Sapphire,
        ItemID.Emerald
            });
            RecipeGroup.RegisterGroup("Cleave:Gem2", group);
            group = new RecipeGroup(() => "Any Tier 3 Gem", new int[]
            {
        ItemID.Ruby,
        ItemID.Diamond
            });
            RecipeGroup.RegisterGroup("Cleave:Gem3", group);
            group = new RecipeGroup(() => "Any Evil Bar", new int[]
            {
        ItemID.DemoniteBar,
        ItemID.CrimtaneBar
            });
            RecipeGroup.RegisterGroup("Cleave:EvilBar", group);
            group = new RecipeGroup(() => "Any Evil Flesh", new int[]
            {
        ItemID.ShadowScale,
        ItemID.TissueSample
            });
            RecipeGroup.RegisterGroup("Cleave:EvilFlesh", group);
            group = new RecipeGroup(() => "Any Tier 3 Hardmode Bar", new int[]
            {
        ItemID.AdamantiteBar,
        ItemID.TitaniumBar
            });
            RecipeGroup.RegisterGroup("Cleave:Tier3HMBar", group);
            group = new RecipeGroup(() => "Any Tier 3 Bar", new int[]
            {
        ItemID.GoldBar,
        ItemID.PlatinumBar
            });
            RecipeGroup.RegisterGroup("Cleave:Tier3Bar", group);
            group = new RecipeGroup(() => "Any Evil Magic", new int[]
            {
        ItemID.CursedFlame,
        ItemID.Ichor
            });
            RecipeGroup.RegisterGroup("Cleave:EvilJuice", group);
            group = new RecipeGroup(() => "Any Ocean Fish", new int[]
            {
        ItemID.RedSnapper,
        ItemID.Shrimp,
        ItemID.Trout,
        ItemID.Tuna
            });
            RecipeGroup.RegisterGroup("Cleave:SaltFish", group);
            group = new RecipeGroup(() => "Any Evil Fish", new int[]
            {
        ItemID.Hemopiranha,
        ItemID.CrimsonTigerfish,
        ItemID.Ebonkoi
            });
            RecipeGroup.RegisterGroup("Cleave:EvilFish", group);
            group = new RecipeGroup(() => "Any Alcohol", new int[]
            {
        ItemID.Sake,
        ItemID.Ale
            });
            RecipeGroup.RegisterGroup("Cleave:ALCOHOL", group);
            group = new RecipeGroup(() => "Any Travelling Merchant Food", new int[]
            {
        ItemID.PadThai,
        ItemID.Pho
            });
            RecipeGroup.RegisterGroup("Cleave:GourmetFood", group);
        }
        public override void Load()
        {
            if (!Main.dedServ)
            {
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/EncounterImminent"), ItemType("EncounterImminentBoxItem"), TileType("EncounterImminentBox"));

                Filters.Scene["Cleave:CrylineSky"] = new Filter(new ScreenShaderData("FilterMiniTower").UseColor(41, 79, 81).UseOpacity(0.0001f), EffectPriority.High);
                SkyManager.Instance["Cleave:CrylineSky"] = new CrylineSky();

                Ref<Effect> berylRef = new Ref<Effect>(GetEffect("Effects/BerylDye"));
                GameShaders.Armor.BindShader(ModContent.ItemType<Items.Images.DyeHeliodor>(), new ArmorShaderData(berylRef, "BerylEffect").UseColor(new Color(120, 188, 93)).UseSecondaryColor(new Color(60, 100, 46.5f)));
                GameShaders.Armor.BindShader(ModContent.ItemType<Items.Images.DyeAquamarine>(), new ArmorShaderData(berylRef, "BerylEffect").UseColor(new Color(140, 237, 255)).UseSecondaryColor(new Color(168, 241, 225)));
                GameShaders.Armor.BindShader(ModContent.ItemType<Items.Images.DyeMorganite>(), new ArmorShaderData(berylRef, "BerylEffect").UseColor(new Color(205, 143, 109)).UseSecondaryColor(new Color(102.5f, 90, 46.5f)));
            }
        }
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }
        }
        public static void DrawDustCircle(Vector2 position, float radius, int dust, int alpha = 0, Color color = default, float scale = 1, int amount = 1)
        {
            for (int i = 0; i < amount; i++)
            {
                Vector2 offset = new Vector2();
                double angle = Main.rand.NextDouble() * 2d * Math.PI;
                offset.X += (float)(Math.Sin(angle) * radius);
                offset.Y += (float)(Math.Cos(angle) * radius);

                Dust d = Dust.NewDustPerfect(position + offset, dust, new Vector2(0, 0), alpha, color, scale);
                d.fadeIn = 0.5f;
                d.noGravity = true;
            }
        }
    }
}