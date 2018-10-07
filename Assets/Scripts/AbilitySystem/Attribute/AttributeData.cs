namespace MorningStudio
{
    public class AttributeData
    {
        private float m_BaseValue;
        private float m_CurrentValue;

        public AttributeData()
        {
            m_BaseValue = 0;
            m_CurrentValue = 0;
        }

        public AttributeData(float defaultValue)
        {
            m_BaseValue = defaultValue;
            m_CurrentValue = defaultValue;
        }

        public float BaseValue
        {
            get { return m_BaseValue; }
            set { m_BaseValue = value; }
        }

        public float CurrentValue
        {
            get { return m_CurrentValue; }
            set { m_CurrentValue = value; }
        }
    }
}