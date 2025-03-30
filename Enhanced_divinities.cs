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
    private DivinitiesManager _divinitiesManager;
    private ChestHuntManager _chestHuntManager;

    private void Awake()
    {
        _divinitiesManager = gameObject.GetComponentInChildren<DivinitiesManager>();
        _chestHuntManager = gameObject.GetComponentInChildren<ChestHuntManager>();

    }

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
