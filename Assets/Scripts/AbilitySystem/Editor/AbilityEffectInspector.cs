using UnityEditor;

namespace MorningStudio
{
    [CustomEditor(typeof(AbilityEffect))]
    public class AbilityEffectInspector : Editor
    {
        private AbilityEffect m_Target;
        private SerializedObject m_SerialObject;
        private SerializedProperty m_DurationType;

        private void OnEnable()
        {
            m_Target = target as AbilityEffect;
            m_SerialObject = new SerializedObject(target);
            m_DurationType = m_SerialObject.FindProperty("durationPolicy");
        }

        public override void OnInspectorGUI()
        {
            m_SerialObject.Update();
            EditorGUILayout.PropertyField(m_DurationType);
            if (m_Target.durationPolicy == AbilityEffectDurationType.HasDuration)
            {
                EditorGUILayout.FloatField("", 0);
            }
            m_SerialObject.ApplyModifiedProperties();
        }
    }
}