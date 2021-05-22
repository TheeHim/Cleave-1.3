using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CleaveModLite.Items.Accessories
{
      [AutoloadEquip(EquipType.Neck)]
    public class MoonScarf : ModItem
    {
        

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Scarf");
            Tooltip.SetDefault("'xseuiln gy9s0p;b'");
         
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 10200;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;

        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            Lighting.AddLight((int)(player.position.X / 16f), (int)(player.position.Y / 16f), 1.35f, 1.35f, 1.35f);
        
    }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }

        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (slot < 10) // This allows the accessory to equip in Vanity slots with no reservations.
            {
                int maxAccessoryIndex = 5 + player.extraAccessorySlots;
                for (int i = 3; i < 3 + maxAccessoryIndex; i++)
                {
                    // We need "slot != i" because we don't care what is currently in the slot we will be replacing.
                    if (slot != i && player.armor[i].type == ItemID.AnkhShield)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }


	// We need to do the same for the AnkhShield so our restriction is enforced both ways.

        }
        

