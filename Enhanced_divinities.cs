using IdleSlayerMods.Common;
using Il2Cpp;
using MelonLoader;
using UnityEngine;
using Input = UnityEngine.Input;
using KeyCode = UnityEngine.KeyCode;
using HarmonyLib;

namespace Enhanced_Divinities;

public class Enhanced_Divinities : MonoBehaviour
{
    [HarmonyPatch(typeof(DivinitiesManager), "PrestigeMinion")]
    public class Patch_PrestigeMinion
    {
        static void Prefix(ref Minion minion)
        {
            minion.level = 100000;
            Plugin.Logger.Msg($"Maximizing minion level: {minion}");
        }
    }
}
