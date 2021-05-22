using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Summoning
{
	public class Plantera_Summon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bizarre Bulb");
			Tooltip.SetDefault("Nips at your fingers. Holding it makes you feel like there's a tyranical presence nearby.");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 12;
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 28;
			item.maxStack = 20;
			item.rare = ItemRarityID.Lime;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return Main.hardMode && NPC.downedPlantBoss;
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Plantera);
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}