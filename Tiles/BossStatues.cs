using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Cleave.Tiles
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
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Statue");
			AddMapEntry(new Color(144, 148, 144), name);
			dustType = DustID.Silver;
			disableSmartCursor = true;
		}
		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 108, 108, ModContent.ItemType<TestStatueItem>());
		}
	}
	public class TestStatueItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eerie Statue");
			Tooltip.SetDefault("Oh... oh my. This is... oh dear.\n`I'll leave when I'm good and ready to. For both our sakes, that better be soon.`");
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
}