using System.Collections;
using System.Collections.Generic;
using Stats_ns;
using StateModifier_ns;
using System.Threading;

public class PirainaStats
{
    //Thread IR_thread= new Thread(new ThreadStart(ScanByType));
    //Thread Freq_thread= new Thread(new ThreadStart(ScanByType));
    //Thread Acoustics_thread= new Thread(new ThreadStart(ScanByType));
    // Start is called before the first frame update
    void Start()
    {
        Stats pirStat = new Stats(1);
        StateModifier IRSig = new StateModifier(1, 0, 1);
        StateModifier FreqSig = new StateModifier(1, 0, 2);
        StateModifier Acoustics = new StateModifier(1, 0, 3);
        pirStat.AddModifier(IRSig);
        pirStat.AddModifier(FreqSig);
        pirStat.AddModifier(Acoustics);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
