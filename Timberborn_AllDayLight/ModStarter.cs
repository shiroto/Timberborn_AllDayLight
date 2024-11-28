using HarmonyLib;
using Timberborn.ModManagerScene;

namespace Timberborn_AllDayLight
{
    public class ModStarter : IModStarter
    {
        public void StartMod(IModEnvironment modEnvironment)
        {
            Harmony harmony = new("com.marcok.alldaylight");
            harmony.PatchAll();
        }
    }
}