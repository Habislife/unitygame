﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [Range(0.1f,10f)][SerializeField] float gameSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
