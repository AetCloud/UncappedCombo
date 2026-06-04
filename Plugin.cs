using BepInEx;
using HarmonyLib;

namespace UncappedCombo
{
    [BepInPlugin("napp.uncappedcombo", "UncappedCombo", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("UncappedCombo loaded");

            Harmony harmony = new Harmony("napp.uncappedcombo");
            harmony.PatchAll();
        }
    }
}