using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Cleave.Tiles
{
	public class TestPainting : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileObsidianKill[Type] = true;
			Main.tileNoAttach[Type] = true;
			TileID.Sets.FramesOnKillWall[Type] = true;
			TileObjectData.newTile.AnchorWall = true;
			TileObjectData.newTile.Origin = new Point16(1, 1);
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
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Painting");
			AddMapEntry(new Color(144, 148, 144), name);
			dustType = DustID.Dirt;
			disableSmartCursor = true;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 108, 108, ModContent.ItemType<TestPaintingItem>());
		}
	}
	public class TestPaintingItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eerie Painting");
			Tooltip.SetDefault("Oh... oh my. This is... oh dear.\n`I'll leave when I'm good and ready to. For both our sakes, that better be soon.`");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.ArmorStatue);
			item.createTile = ModContent.TileType<TestPainting>();
			item.placeStyle = 0;
			item.height = 96;
			item.height = 96;
		}
	}
}