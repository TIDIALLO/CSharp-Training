

namespace testEventDelegate;

public class Counter
{
    public int threshold;
    public int total;


    public Counter(int passedThreshold)
    {
        threshold = passedThreshold;
    }

    public void Add(int x)
    {
        total += x;
        if (total >= threshold)
        {
            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
            args.Threshold = threshold;
            args.TimeReached = DateTime.Now;
            OnThresholdReached(args);
        }
    }
    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    {
        EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
        if (handler != null)
        {   
            handler(this, e);
        }
    }

    public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
}

public class ThresholdReachedEventArgs : EventArgs
{
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }
}