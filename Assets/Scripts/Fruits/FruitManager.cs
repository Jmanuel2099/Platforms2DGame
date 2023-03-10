using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public static bool isAllFruitsCollected = false;
    [SerializeField] private Text fruitsCollected;
    [SerializeField] private Text totalFruits;
    private int totalFruitsInLevel;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }
    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }

    public void AllFruitsCollected()
    {
        if (transform.childCount == 0)
        {
            isAllFruitsCollected = true;
        }
    }
}
