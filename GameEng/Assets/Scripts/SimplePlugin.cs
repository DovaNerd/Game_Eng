using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using UnityEngine.AI;

public class SimplePlugin : MonoBehaviour
{
    [DllImport("Dll_speed")]
    private static extern int SpeedChange();


    NavMeshAgent agent;

    void Start()
    {
        int newSpeed = SpeedChange();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = newSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
