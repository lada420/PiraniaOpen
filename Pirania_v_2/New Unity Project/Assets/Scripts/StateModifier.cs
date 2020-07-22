namespace StateModifier_ns
{
    public enum StatModType
    {
        Flat,
        Percent,
    }
    
    public class StateModifier
    {
        public readonly float Value;
        public readonly StatModType Type;
        public readonly int Order;
    
        public StateModifier(float val, StatModType type, int order)
        {
            Value = val;
            Type = type;
            Order = order;
        }
    
        public StateModifier(float value, StatModType type) : this (value, type, (int)type){}
    }

}



