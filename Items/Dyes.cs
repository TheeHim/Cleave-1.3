using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave.Items.Images
{
	public class DyeHeliodor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heliodor Beryl Dye");
		}
		//PlayerHooks.GetDyeTraderReward(this, list);
		public override void SetDefaults()
		{
			/*				
			this.name = "Gel Dye";
			this.width = 20;
			this.height = 20;
			this.maxStack = 99;
			this.value = Item.sellPrice(0, 1, 50, 0);
			this.rare = 3;
			*/
			// item.dye is already assigned to this item prior to SetDefaults because of the GameShaders.Armor.BindShader code in ExampleMod.Load. 
			// This code here remembers item.dye so that information isn't lost during CloneDefaults. The above code is the data being cloned by CloneDefaults, for informational purposes.
			byte dye = item.dye;
			item.CloneDefaults(ItemID.GelDye);
			item.dye = dye;
		}
	}
	public class DyeMorganite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Morganite Beryl Dye");
		}
		//PlayerHooks.GetDyeTraderReward(this, list);
		public override void SetDefaults()
		{
			/*				
			this.name = "Gel Dye";
			this.width = 20;
			this.height = 20;
			this.maxStack = 99;
			this.value = Item.sellPrice(0, 1, 50, 0);
			this.rare = 3;
			*/
			// item.dye is already assigned to this item prior to SetDefaults because of the GameShaders.Armor.BindShader code in ExampleMod.Load. 
			// This code here remembers item.dye so that information isn't lost during CloneDefaults. The above code is the data being cloned by CloneDefaults, for informational purposes.
			byte dye = item.dye;
			item.CloneDefaults(ItemID.GelDye);
			item.dye = dye;
		}
	}
	public class DyeAquamarine : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquamarine Beryl Dye");
		}
		//PlayerHooks.GetDyeTraderReward(this, list);
		public override void SetDefaults()
		{
			/*				
			this.name = "Gel Dye";
			this.width = 20;
			this.height = 20;
			this.maxStack = 99;
			this.value = Item.sellPrice(0, 1, 50, 0);
			this.rare = 3;
			*/
			// item.dye is already assigned to this item prior to SetDefaults because of the GameShaders.Armor.BindShader code in ExampleMod.Load. 
			// This code here remembers item.dye so that information isn't lost during CloneDefaults. The above code is the data being cloned by CloneDefaults, for informational purposes.
			byte dye = item.dye;
			item.CloneDefaults(ItemID.GelDye);
			item.dye = dye;
		}
	}
}