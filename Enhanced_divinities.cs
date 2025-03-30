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

    public void Start()
    {
        // Obtener todos los objetos en la escena
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();

        foreach (var obj in allObjects)
        {
            Plugin.Logger.Msg($"GameObject found: {obj.name}");
        }
    }

    // private void Update()
    // {
    //     // _minionManager.ClaimAll();
    //     if (Input.GetKeyDown(KeyCode.O))
    //     {
    //         _chestHuntManager.StartEvent();
    //     }

    //     // var minions = FindObjectsOfType<Minion>(); // Encuentra todos los minions en la escena
    //     // foreach (var minion in minions)
    //     // {
    //     //     Plugin.Logger.Msg($"Obtained minio: {minion}");
    //     //     minion.level = minion.maxLevel;
    //     // }
    // }

    [HarmonyPatch(typeof(DivinitiesManager), "PrestigeMinion")]
    public class Patch_PrestigeMinion
    {
        static void Prefix(ref Minion minion)
        {
            minion.level = 10000;
            Plugin.Logger.Msg($"Maximizing minion level: {minion}");
        }
    }
}
