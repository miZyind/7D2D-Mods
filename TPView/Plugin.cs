using HarmonyLib;

class TPView : IModApi
{
    void IModApi.InitMod(Mod _modInstance)
    {
        Harmony.CreateAndPatchAll(typeof(TPView));
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerMoveController), "updateRespawn")]
    static void updateRespawn(ref EntityPlayerLocal ___entityPlayerLocal)
    {
        if (___entityPlayerLocal.Spawned && ___entityPlayerLocal.bFirstPersonView)
        {
            ___entityPlayerLocal.SwitchFirstPersonView(true);
        }
    }
}
