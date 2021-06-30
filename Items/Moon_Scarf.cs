using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Images
{
    [AutoloadEquip(EquipType.Neck)]
    public class Moon_Scarf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moon Scarf");
            Tooltip.SetDefault("A lil' wormy guy to keep your neck warm. Seems to be from another dimension.\nGlows like the twilight moon.");

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
}