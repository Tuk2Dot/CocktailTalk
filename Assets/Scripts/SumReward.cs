using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumReward : MonoBehaviour
{
    public int totalReward = 0;

    public void sumReward(int r)
    {
        totalReward += r;
    }
}
