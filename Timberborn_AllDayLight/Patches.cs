using HarmonyLib;
using Timberborn.SkySystem;

namespace Timberborn_AllDayLight
{
    [HarmonyPatch]
    public class Patches
    {
        [HarmonyPatch(typeof(Sun), "UpdateColors", typeof(DayStageTransition))]
        public static bool Prefix()
        {
            return false;
        }
    }
}