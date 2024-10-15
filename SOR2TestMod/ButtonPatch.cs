using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[HarmonyPatch(typeof(MenuGUISOR2), "CreateNewButtonData", new Type[] {typeof(string), typeof(bool), typeof(string), typeof(bool)})]
static class ButtonPatch
{

    private static ButtonData Postfix(ButtonData data)
    {
        data.interactable = true;
        return data;
    }
}