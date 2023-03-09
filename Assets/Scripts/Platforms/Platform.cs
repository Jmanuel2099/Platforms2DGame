using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PlatformEffector2D effector;

    [Header("Time")]
    [SerializeField] private float startWaitTime;
    private float WaitedTime;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            WaitedTime = startWaitTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (WaitedTime <= 0f)
            {
                effector.rotationalOffset = 180;
                WaitedTime = startWaitTime;
            }
            else
            {
                WaitedTime -= Time.deltaTime;
            }
        }

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            effector.rotationalOffset = 0;
        }
    }
}
