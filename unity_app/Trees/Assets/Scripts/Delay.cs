using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay
{
    public float WaitTime;
    private float completionTime;

    public Delay(float waitTime)
    {
        WaitTime = waitTime;
        Reset();
    }

    public void Reset()
    {
        completionTime = Time.time + WaitTime;
    }

    public bool IsReady { get { return Time.time >= completionTime; } }
}
