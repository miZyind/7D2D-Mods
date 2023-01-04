using BepInEx;
using HarmonyLib;
using UnityEngine;

[BepInPlugin("miZyind.TPView", "TPView", "2023.01.04")]
class TPView : BaseUnityPlugin
{
    void Awake()
    {
        Harmony.CreateAndPatchAll(typeof(TPView));
    }
}
