using UnityEngine;

namespace MorningStudio
{
    [CreateAssetMenu(menuName = "AbilitySystem/Create AbilityEffect")]
    public class AbilityEffect : ScriptableObject
    {
        public AbilityEffectDurationType durationPolicy;
    }
}