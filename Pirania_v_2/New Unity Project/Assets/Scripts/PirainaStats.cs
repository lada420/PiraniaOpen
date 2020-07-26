using System.Collections;
using System.Collections.Generic;
using Stats_ns;
using StateModifier_ns;
using System.Threading;
using System;

namespace PiraniaStats_ns
{
    public enum SigType
    {
        Freq,
        IR,
        Acoustics,
    }

    public class PirainaStats
    {
        float dummy = 0;
        

        Stats pirStat = new Stats(1);
        StateModifier IRSig = new StateModifier(1, StatModType.Percent, 1);
        StateModifier FreqSig = new StateModifier(1, StatModType.Percent, 2);
        StateModifier Acoustics = new StateModifier(1, StatModType.Percent, 3);

        void Start()
        {
            pirStat.AddModifier(IRSig);
            pirStat.AddModifier(FreqSig);
            pirStat.AddModifier(Acoustics);
        }

        // Update is called once per frame
        void Update()
        {
            IRSig.CalculateFinalValue(SigType.IR, dummy);
            FreqSig.CalculateFinalValue(SigType.Freq, dummy);
            Acoustics.CalculateFinalValue(SigType.Acoustics, dummy);
            pirStat.CalculateResValue();
        }
    }

}
