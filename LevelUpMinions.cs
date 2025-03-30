using IdleSlayerMods.Common;
using Il2Cpp;
using MelonLoader;
using UnityEngine;
using UnityEngine.Playables;

namespace Enhanced_Divinities;

public class LevelUpMinions : MonoBehaviour
{
    // private MinionManager _minionManager;
    // private DivinitiesManager _divinitiesManager;
    // private Divinity _divinity;
    private Minions _minions;

    // I was unable to get MinionsManager or DivinitiesManager GameObject, this file is useless.
    public void Awake()
    {
        // var divinitiesManager = GameObject.Find("Divinities Manager/Instance");
        // _divinitiesManager = divinitiesManager.GetComponentInChildren<DivinitiesManager>();

    }
    public void Start()
    {
        Plugin.Logger.Msg("LevelUpMinions component initialized!");
        // Plugin.Logger.Msg("Please delete these logs to keep the console clean!");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            var minions = GameObject.Find("Minions");
            _minions = minions.GetComponentInChildren<Minions>();
            // _minionManager.ClaimAll();
            Plugin.Logger.Msg(_minions.gameObject);

        }
    }
}
