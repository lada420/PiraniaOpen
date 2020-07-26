using System;
using PiraniaStats_ns;

namespace StateModifier_ns
{
    public enum StatModType
    {
        Flat,
        Percent,
    }
    
    public class StateModifier
    {
        public float Value;
        public float FinalValue;
        public readonly StatModType Type;
        public readonly int Order;
    
        public StateModifier(float val, StatModType type, int order)
        {
            Value = val;
            Type = type;
            Order = order;
        }
    
        public StateModifier(float value, StatModType type) : this (value, type, (int)type){}

        public void UpdateValue(float new_val)
        {
            if (new_val >= 0)
                Value = new_val;
            else
                Value = 0;
        }

        public void CalculateFinalValue(SigType type, float new_val)
        {
            UpdateValue(new_val); //Sanity check
            switch(type)
            {
                case(SigType.Freq):
                    FinalValue = 0;
                    break;
                case(SigType.IR):
                    FinalValue = 0;
                    break;
                case(SigType.Acoustics):
                    FinalValue = 0;
                    break;

            }
                
            
        }
    }

}



