using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_manager : MonoBehaviour
{
    #region Singleton

    public static Player_manager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
}
