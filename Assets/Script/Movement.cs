﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
       float horizontalThrow = Input.GetAxis("Horizontal");
       Debug.Log(horizontalThrow);
        
    }
}
