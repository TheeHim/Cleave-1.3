using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cleave
{
    public class CleavePlayer : ModPlayer
    {
        public bool Moyai;

        public override void ResetEffects()
        {
            Moyai = false;
        }
    }
}