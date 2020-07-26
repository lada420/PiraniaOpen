using System.Collections;
using System.Collections.Generic;
using Stats_ns;
using StateModifier_ns;
using System.Threading;

public class PirainaStats
{
    public static void ThreadProc(Stats pirStat)
    {
        
    }

    Thread IR_thread= new Thread(new ThreadStart(ThreadProc));
    Thread Freq_thread= new Thread(new ThreadStart(ThreadProc));
    Thread Acoustics_thread= new Thread(new ThreadStart(ThreadProc));
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
