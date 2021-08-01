using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace Cleave.Tiles.Images
{
    public class BossStatue : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style6x3);
            TileObjectData.newTile.Height = 6;
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
            TileObjectData.newTile.Origin = new Point16(4, 4);
            TileObjectData.newTile.StyleWrapLimit = 18;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Boss Statue");
            AddMapEntry(new Color(144, 148, 144), name);
            dustType = DustID.Silver;
            disableSmartCursor = true;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int item = 0;
            switch (frameX / 108)
            {
                case 0:
                    item = ModContent.ItemType<StatueSlimeItem>();
                    break;
                case 1:
                    item = ModContent.ItemType<StatueEyeItem>();
                    break;
                case 2:
                    item = ModContent.ItemType<StatueEaterItem>();
                    break;
                case 3:
                    item = ModContent.ItemType<StatueBrainItem>();
                    break;
                case 4:
                    item = ModContent.ItemType<StatueBeeItem>();
                    break;
                case 5:
                    item = ModContent.ItemType<StatueSkeleItem>();
                    break;
                case 6:
                    item = ModContent.ItemType<StatueFleshItem>();
                    break;
                case 7:
                    item = ModContent.ItemType<StatueQSlimeItem>();
                    break;
                case 8:
                    item = ModContent.ItemType<StatueTwinItem>();
                    break;
                case 9:
                    item = ModContent.ItemType<StatueDestItem>();
                    break;
                case 10:
                    item = ModContent.ItemType<StatuePrimeItem>();
                    break;
                case 11:
                    item = ModContent.ItemType<StatuePlantItem>();
                    break;
                case 12:
                    item = ModContent.ItemType<StatueGolemItem>();
                    break;
                case 13:
                    item = ModContent.ItemType<StatueLightItem>();
                    break;
                case 14:
                    item = ModContent.ItemType<StatueDukeItem>();
                    break;
                case 15:
                    item = ModContent.ItemType<StatueCultItem>();
                    break;
                case 16:
                    item = ModContent.ItemType<StatueMoonItem>();
                    break;
                    /*
				case 17:
					item = ModContent.ItemType<StatueCatItem>();
					break;
				case 18:
					item = ModContent.ItemType<StatueSpiderItem>();
					break;
				case 19:
					item = ModContent.ItemType<StatueCrystalItem>();
					break;
				case 20:
					item = ModContent.ItemType<StatueSnakeItem>();
					break;
				case 21:
					item = ModContent.ItemType<StatueGirlItem>();
					break;
				case 22:
					item = ModContent.ItemType<StatueColdItem>();
					break;
				case 23:
					item = ModContent.ItemType<StatueBirdItem>();
					break;
				case 24:
					item = ModContent.ItemType<StatueAssItem>();
					break;
				case 25:
					item = ModContent.ItemType<StatueAsgoreItem>();
					break;
				case 26:
					item = ModContent.ItemType<StatueTorielItem>();
					break;
				case 27:
					item = ModContent.ItemType<StatueFireItem>();
					break;
				case 28:
					item = ModContent.ItemType<StatueWaterItem>();
					break;
				case 29:
					item = ModContent.ItemType<StatueWitchItem>();
					break;
				case 30:
					item = ModContent.ItemType<StatueSquidItem>();
					break;
				case 31:
					item = ModContent.ItemType<StatueBallItem>();
					break;
				case 32:
					item = ModContent.ItemType<StatueGodItem>();
					break;
				case 33:
					item = ModContent.ItemType<StatueBoyItem>();
					break;
				case 34:
					item = ModContent.ItemType<StatueSwordItem>();
					break;
				case 35:
					item = ModContent.ItemType<StatueFoxItem>();
					break;
				case 36:
					item = ModContent.ItemType<StatueBloodItem>();
					break;
				case 37:
					item = ModContent.ItemType<StatueBookItem>();
					break;
				case 38:
					item = ModContent.ItemType<StatueOldItem>();
					break;
				case 39:
					item = ModContent.ItemType<StatueYoungItem>();
					break;
				case 40:
					item = ModContent.ItemType<StatueStopItem>();
					break;
					*/
            }
            if (item > 0)
            {
                Item.NewItem(i * 16, j * 16, 108, 108, item);
            }
        }
    }
    public class StatueSlimeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King Slime Statue");
            Tooltip.SetDefault("A statue in the image of the King Slime.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 0;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.KingSlimeMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueEyeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eye of Cthulhu Statue");
            Tooltip.SetDefault("A statue in the image of the Eye of Cthulhu.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 1;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.KingSlimeMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueEaterItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eater of Worlds Statue");
            Tooltip.SetDefault("A statue in the image of the Eater of Worlds.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 2;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.KingSlimeMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueBrainItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brain of Cthulhu Statue");
            Tooltip.SetDefault("A statue in the image of the Brain of Cthulhu.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 3;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BrainMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueBeeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Bee Statue");
            Tooltip.SetDefault("A statue in the image of the Queen Bee.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 4;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueSkeleItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skeletron Statue");
            Tooltip.SetDefault("A statue in the image of Skeletron.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 5;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SkeletronMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueFleshItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wall of Flesh Statue");
            Tooltip.SetDefault("A statue in the image of the Wall of Flesh.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 6;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FleshMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueQSlimeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Queen Slime Statue");
            Tooltip.SetDefault("A statue in the image of the Queen Slime.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 7;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.KingSlimeMask);
            recipe.AddIngredient(ItemID.CrystalShard, 50);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueTwinItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Twins Statue");
            Tooltip.SetDefault("A statue in the image of the Twins.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 8;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TwinMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueDestItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Destroyer Statue");
            Tooltip.SetDefault("A statue in the image of the Destroyer.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 9;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DestroyerMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatuePrimeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skeletron Prime Statue");
            Tooltip.SetDefault("A statue in the image of Skeletron Prime.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 10;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SkeletronPrimeMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatuePlantItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plantera Statue");
            Tooltip.SetDefault("A statue in the image of Plantera.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 11;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlanteraMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueGolemItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golem Statue");
            Tooltip.SetDefault("A statue in the image of Golem.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 12;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GolemMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueLightItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Empress of Light Statue");
            Tooltip.SetDefault("A statue in the image of the Empress of Light.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 13;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BossMaskCultist);
            recipe.AddIngredient(ItemID.SoulofLight, 50);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueDukeItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Duke Fishron Statue");
            Tooltip.SetDefault("A statue in the image of Duke Fishron.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 14;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DukeFishronMask);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueCultItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunatic Cultist Statue");
            Tooltip.SetDefault("A statue in the image of the Lunatic Cultist.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 15;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BossMaskCultist);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class StatueMoonItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Lord Statue");
            Tooltip.SetDefault("A statue in the image of the Moon Lord.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ArmorStatue);
            item.createTile = ModContent.TileType<BossStatue>();
            item.placeStyle = 16;
            item.height = 96;
            item.height = 96;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BossMaskMoonlord);
            recipe.AddIngredient(mod.ItemType("Mystic_Rock"), 10);
            recipe.AddIngredient(mod.ItemType("Bossmatter"), 10);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    /*
	public class StatueCatItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aynayn Statue");
			Tooltip.SetDefault("A statue in the image of Aynayn.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueSpiderItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rachnas Statue");
			Tooltip.SetDefault("A statue in the image of Rachnas.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueCrystalItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Queen Diameen Statue");
			Tooltip.SetDefault("A statue in the image of Queen Diameen.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueSnakeItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ourbos Statue");
			Tooltip.SetDefault("A statue in the image of Ourbos.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueGirlItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tressus Statue");
			Tooltip.SetDefault("A statue in the image of Tressus.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueColdItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fridjin Statue");
			Tooltip.SetDefault("A statue in the image of Fridjin.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueBirdItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eldras Statue");
			Tooltip.SetDefault("A statue in the image of Eldras.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueAssItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lorm Statue");
			Tooltip.SetDefault("A statue in the image of Lorm.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueAsgoreItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Agero Statue");
			Tooltip.SetDefault("A statue in the image of Agero.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueTorielItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Riel Statue");
			Tooltip.SetDefault("A statue in the image of Riel.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueFireItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jharius Statue");
			Tooltip.SetDefault("A statue in the image of Jharius.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueWaterItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Liki Statue");
			Tooltip.SetDefault("A statue in the image of Liki.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueWitchItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sun Slime Witch Statue");
			Tooltip.SetDefault("A statue in the image of the Sun Slime Witch.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueSquidItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Calirim Statue");
			Tooltip.SetDefault("A statue in the image of Calirim.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueBallItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terminal Elemental Statue");
			Tooltip.SetDefault("A statue in the image of the Terminal Elemental.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueGodItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rism Statue");
			Tooltip.SetDefault("A statue in the image of Rism.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueBoyItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ailks Statue");
			Tooltip.SetDefault("A statue in the image of Ailks.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueSwordItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Klyv Statue");
			Tooltip.SetDefault("A statue in the image of Klyv.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueFoxItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Miamiu Statue");
			Tooltip.SetDefault("A statue in the image of Miamiu.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueBloodItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kulidai Statue");
			Tooltip.SetDefault("A statue in the image of Kulidai.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueBookItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cibrali Statue");
			Tooltip.SetDefault("A statue in the image of Cibrali.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueOldItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dabadie Statue");
			Tooltip.SetDefault("A statue in the image of Dabadie.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueYoungItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lumini Statue");
			Tooltip.SetDefault("A statue in the image of Lumini.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	public class StatueStopItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Owrd Statue");
			Tooltip.SetDefault("A statue in the image of Owrd.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<BossStatue>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
	*/
}