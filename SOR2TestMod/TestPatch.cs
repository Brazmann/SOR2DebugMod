using System;
using System.Collections.Generic;
using System.Text;
    using HarmonyLib;
using UnityEngine;

    [HarmonyPatch(typeof(GameController), "RealStart")]
    static class GameControllerPatch
    {   
        
        private static void Prefix()
        {

        }

        private static void Postfix()
        {
            GameController.gameController.debugControls = true;
        }
    }