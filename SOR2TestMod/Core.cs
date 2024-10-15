using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(SOR2DebugMod.Core), "SOR2DebugMod", "1.0.0", "Brazman", null)]
[assembly: MelonGame("Streets of Rogue 2", "Streets of Rogue 2")]

namespace SOR2DebugMod
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            HarmonyInstance.PatchAll();
        }

        public override void OnLateUpdate()
        {

        }
    }
}