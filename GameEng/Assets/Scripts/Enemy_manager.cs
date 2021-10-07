using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_manager : MonoBehaviour
{
    #region Singleton

    public static Enemy_manager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
}
