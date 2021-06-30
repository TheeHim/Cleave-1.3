using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Cleave
{
    public class Cleave : Mod
    {
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
		}
	}
}