using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Cleave.Items.Tiles
{
    public class Planet_Block : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            drop = ModContent.ItemType<Items.Tiles.Planet_Block_Item>();
            AddMapEntry(new Color(167, 37, 89));
        }
    }
}