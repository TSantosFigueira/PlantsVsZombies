using UnityEngine;
using System.Collections;

public class RemoveMoney : MonoBehaviour {

    public int moneyLoserFactor;
    
    public int cashToLose
    {
        get { return Bounds.crossedBounds * moneyLoserFactor; }
    }
}
