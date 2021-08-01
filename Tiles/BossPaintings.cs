using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Cleave.Tiles.Images
{
    public class BossPainting : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            Main.tileNoAttach[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;
            TileObjectData.newTile.AnchorWall = true;
            TileObjectData.newTile.Origin = new Point16(4, 4);
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.LavaDeath = true;
            TileObjectData.newTile.Height = 6;
            TileObjectData.newTile.Width = 6;
            disableSmartCursor = true;
            TileObjectData.newTile.CoordinateHeights = new[]
            {
                16,
                16,
                16,
                16,
                16,
                16
            };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 19;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Painting");
            AddMapEntry(new Color(144, 148, 144), name);
            dustType = DustID.Dirt;
            disableSmartCursor = true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int item = 0;
            switch (frameX / 108)
            {
                case 0:
                    item = ModContent.ItemType<PaintingSlimeItem>();
                    break;
                case 1:
                    item = ModContent.ItemType<PaintingEyeItem>();
                    break;
                case 2:
                    item = ModContent.ItemType<PaintingEaterItem>();
                    break;
                case 3:
                    item = ModContent.ItemType<PaintingBrainItem>();
                    break;
                case 4:
                    item = ModContent.ItemType<PaintingBeeItem>();
                    break;
                case 5:
                    item = ModContent.ItemType<PaintingSkeleItem>();
                    break;
                case 6:
                    item = ModContent.ItemType<PaintingFleshItem>();
                    break;
                case 7:
                    item = ModContent.ItemType<PaintingQSlimeItem>();
                    break;
                case 8:
                    item = ModContent.ItemType<PaintingRetItem>();
                    break;
                case 9:
                    item = ModContent.ItemType<PaintingSpazItem>();
                    break;
                case 10:
                    item = ModContent.ItemType<PaintingDestItem>();
                    break;
                case 11:
                    item = ModContent.ItemType<PaintingPrimeItem>();
                    break;
                case 12:
                    item = ModContent.ItemType<PaintingPlantItem>();
                    break;
                case 13:
                    item = ModContent.ItemType<PaintingGolemItem>();
                    break;
                case 14:
                    item = ModContent.ItemType<PaintingLightItem>();
                    break;
                case 15:
                    item = ModContent.ItemType<PaintingDukeItem>();
                    break;
                case 16:
                    item = ModContent.ItemType<PaintingCultItem>();
                    break;
                case 17:
                    item = ModContent.ItemType<PaintingMoonItem>();
                    break;
                    /*
				case 18:
					item = ModContent.ItemType<PaintingCatItem>();
					break;
				case 19:
					item = ModContent.ItemType<PaintingSpiderItem>();
					break;
				case 20:
					item = ModContent.ItemType<PaintingCrystalItem>();
					break;
				case 21:
					item = ModContent.ItemType<PaintingSnakeItem>();
					break;
				case 22:
					item = ModContent.ItemType<PaintingGirlItem>();
					break;
				case 23:
					item = ModContent.ItemType<PaintingColdItem>();
					break;
				case 24:
					item = ModContent.ItemType<PaintingBirdItem>();
					break;
				case 25:
					item = ModContent.ItemType<PaintingAssItem>();
					break;
				case 26:
					item = ModContent.ItemType<PaintingAsgoreItem>();
					break;
				case 27:
					item = ModContent.ItemType<PaintingTorielItem>();
					break;
				case 28:
					item = ModContent.ItemType<PaintingFireItem>();
					break;
				case 29:
					item = ModContent.ItemType<PaintingWaterItem>();
					break;
				case 30:
					item = ModContent.ItemType<PaintingWitchItem>();
					break;
				case 31:
					item = ModContent.ItemType<PaintingSquidItem>();
					break;
				case 32:
					item = ModContent.ItemType<PaintingBallItem>();
					break;
				case 33:
					item = ModContent.ItemType<PaintingGodItem>();
					break;
				case 34:
					item = ModContent.ItemType<PaintingBoyItem>();
					break;
				case 35:
					item = ModContent.ItemType<PaintingSwordItem>();
					break;
				case 36:
					item = ModContent.ItemType<PaintingFoxItem>();
					break;
				case 37:
					item = ModContent.ItemType<PaintingBloodItem>();
					break;
				case 38:
					item = ModContent.ItemType<PaintingBookItem>();
					break;
				case 39:
					item = ModContent.ItemType<PaintingOldItem>();
					break;
				case 40:
					item = ModContent.ItemType<PaintingYoungItem>();
					break;
				case 41:
					item = ModContent.ItemType<PaintingStopItem>();
					break;
                    */
            }
            if (item > 0)
            {
                Item.NewItem(i * 16, j * 16, 108, 108, item);
            }
        }
    }
    public class PaintingSlimeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King Slime Painting");
            Tooltip.SetDefault("An artistic depiction of the King Slime.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 0;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.KingSlimeTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingEyeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eye of Cthulhu Painting");
            Tooltip.SetDefault("An artistic depiction of the Eye of Cthulhu.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 1;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EyeofCthulhuTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingEaterItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eater of Worlds Painting");
            Tooltip.SetDefault("An artistic depiction of the Eater of Worlds.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 2;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EaterofWorldsTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingBrainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brain of Cthulhu Painting");
            Tooltip.SetDefault("An artistic depiction of the Brain of Cthulhu.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 3;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BrainofCthulhuTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingBeeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Bee Painting");
            Tooltip.SetDefault("An artistic depiction of the Queen Bee.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 4;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.QueenBeeTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingSkeleItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skeletron Painting");
            Tooltip.SetDefault("An artistic depiction of Skeletron.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 5;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SkeletronTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingFleshItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wall of Flesh Painting");
            Tooltip.SetDefault("An artistic depiction of the Wall of Flesh.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 6;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WallofFleshTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingQSlimeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Slime Painting");
            Tooltip.SetDefault("An artistic depiction of the Queen Slime.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 7;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalShard, 50);
            recipe.AddIngredient(mod.ItemType("PaintingSlimeItem"));
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingRetItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Retinazer Painting");
            Tooltip.SetDefault("An artistic depiction of Retinazer.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 8;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RetinazerTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingSpazItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spazmatism Painting");
            Tooltip.SetDefault("An artistic depiction of Spazmatism.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 9;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpazmatismTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingDestItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Destroyer Painting");
            Tooltip.SetDefault("An artistic depiction of the Destroyer.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 10;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DestroyerTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingPrimeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skeletron Prime Painting");
            Tooltip.SetDefault("An artistic depiction of Skeletron Prime.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 11;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SkeletronPrimeTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingPlantItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plantera Painting");
            Tooltip.SetDefault("An artistic depiction of Plantera.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 12;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlanteraTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingGolemItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golem Painting");
            Tooltip.SetDefault("An artistic depiction of Golem.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 13;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GolemTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingLightItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empress of Light Painting");
            Tooltip.SetDefault("An artistic depiction of the Empress of Light.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 14;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight, 50);
            recipe.AddIngredient(mod.ItemType("PaintingCultItem"));
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingDukeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Duke Fishron Painting");
            Tooltip.SetDefault("An artistic depiction of Duke Fishron.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 15;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DukeFishronTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingCultItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunatic Cultist Painting");
            Tooltip.SetDefault("An artistic depiction of the Lunatic Cultist.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 16;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AncientCultistTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingMoonItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Lord Painting");
            Tooltip.SetDefault("An artistic depiction of the Moon Lord.\n`Chankmon`");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 17;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MoonLordTrophy);
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    /*
    public class PaintingCatItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aynayn Painting");
            Tooltip.SetDefault("An artistic depiction of Aynayn.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 18;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Aynayn_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingSpiderItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rachnas Painting");
            Tooltip.SetDefault("An artistic depiction of Rachnas.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 19;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Rachnas_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingCrystalItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Diameen Painting");
            Tooltip.SetDefault("An artistic depiction of Queen Diameen.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 20;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Queen_Diameen_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingSnakeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ourbos Painting");
            Tooltip.SetDefault("An artistic depiction of Ourbos.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 21;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Ourbos_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingGirlItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tressus Painting");
            Tooltip.SetDefault("An artistic depiction of Tressus.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 22;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Tressus_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingColdItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fridjin Painting");
            Tooltip.SetDefault("An artistic depiction of Fridjin.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 23;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Fridjin_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingBirdItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eldras Painting");
            Tooltip.SetDefault("An artistic depiction of Eldras.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 24;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Eldras_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingAssItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lorm Painting");
            Tooltip.SetDefault("An artistic depiction of Lorm.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 25;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Lorm_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingAsgoreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Agero Painting");
            Tooltip.SetDefault("An artistic depiction of Agero.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 26;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Agero_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingTorielItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Riel Painting");
            Tooltip.SetDefault("An artistic depiction of Riel.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 27;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Riel_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingFireItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jharius Painting");
            Tooltip.SetDefault("An artistic depiction of Jharius.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 28;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Jharius_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingWaterItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Liki Painting");
            Tooltip.SetDefault("An artistic depiction of Liki.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 29;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Liki_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingWitchItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sun Slime Witch Painting");
            Tooltip.SetDefault("An artistic depiction of the Sun Slime Witch.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 30;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SSW_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingSquidItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Calirim Painting");
            Tooltip.SetDefault("An artistic depiction of Calirim.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 31;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Calirim_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingBallItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terminal Elemental Painting");
            Tooltip.SetDefault("An artistic depiction of the Terminal Elemental.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 32;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Ball_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingGodItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rism Painting");
            Tooltip.SetDefault("An artistic depiction of Rism.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 33;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Rism_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingBoyItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ailks Painting");
            Tooltip.SetDefault("An artistic depiction of Ailks.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 34;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Aynayn_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingSwordItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Klyv Painting");
            Tooltip.SetDefault("An artistic depiction of Klyv.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 35;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Klyv_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingFoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Miamiu Painting");
            Tooltip.SetDefault("An artistic depiction of Miamiu.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 36;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Miamiu_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingBloodItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kulidai Painting");
            Tooltip.SetDefault("An artistic depiction of Kulidai.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 37;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Kulidai_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingBookItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cibrali Painting");
            Tooltip.SetDefault("An artistic depiction of Cibrali.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 38;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Cibrali_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingOldItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dabadie Painting");
            Tooltip.SetDefault("An artistic depiction of Dabadie.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 39;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Dabadie_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingYoungItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lumini Painting");
            Tooltip.SetDefault("An artistic depiction of Lumini.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 40;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Lumini_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class PaintingStopItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Owrd Painting");
            Tooltip.SetDefault("An artistic depiction of Owrd.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossPainting>();
            item.placeStyle = 41;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("Owrd_Trophy"));
            recipe.AddIngredient(mod.ItemType("Magic_Canvas"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    */
}