using System;
using System.Collections.Generic;
using StateModifier_ns;

namespace Stats_ns
{

    public class Stats 
    {
        public float BaseValue;
    
        public float Value {
            get 
            {
                if(isDirty)
                {
                    _value =  CalculateResValue();
                    isDirty = false;
                }
                return _value;
            }
        }
    
        private bool isDirty = true;
        private float _value;
    
        private readonly List<StateModifier> stateModifiers;
    
        public Stats(float baseValue)
        {
            BaseValue = baseValue;
            stateModifiers = new List<StateModifier>();
        }
    
        public void AddModifier(StateModifier mod)
        {
            isDirty = true;
            stateModifiers.Add(mod);
            stateModifiers.Sort(CompareModifierOrder);
        }
    
        private int CompareModifierOrder(StateModifier lhs, StateModifier rhs)
        {
            if (lhs.Order < rhs.Order)
                return -1;
            else if(lhs.Order > rhs.Order)
                return 1;
            return 0;
        }
    
        public bool RemoveModifier(StateModifier mod)
        {
            isDirty = true;
            return stateModifiers.Remove(mod);
        }
    
        public float CalculateResValue()
        {
            float finalValue = BaseValue;
    
            foreach(StateModifier stat in stateModifiers)
            {
                StateModifier mod = stat;
                if(mod.Type == StatModType.Flat)
                {
                    finalValue += stat.Value;
                }
                else if(mod.Type == StatModType.Percent)
                {
                    finalValue *= 1 + mod.Value;
                }
            }
            return (float)Math.Round(finalValue, 4);
        }
    
    
    }
}