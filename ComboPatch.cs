using HarmonyLib;
using UnityEngine.UI;

namespace UncappedCombo
{
    [HarmonyPatch(typeof(GameController), "doScoreText")]
    public class ComboPatch
    {
        static void Postfix(GameController __instance)
        {
            var field = AccessTools.Field(typeof(GameController), "highestcombocounter");
            int combo = (int)(field.GetValue(__instance) ?? 0);

            var mult = AccessTools.Field(typeof(GameController), "multtext")
                .GetValue(__instance) as Text;

            var shadow = AccessTools.Field(typeof(GameController), "multtextshadow")
                .GetValue(__instance) as Text;

            if (mult == null || shadow == null)
                return;

            mult.text = $"{combo}x";
            shadow.text = mult.text;
        }
    }
}