using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public void IsAllFruitsCollected()
    {
        if (transform.childCount == 1)
        {
            Debug.Log("level complete");
        }
    }
}
