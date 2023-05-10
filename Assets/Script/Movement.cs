using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
       float xThrow = Input.GetAxis("Horizontal");
       float yThrow = Input.GetAxis("Vertical");
       float xOffSet = .1f;
       float newXPos = transform.localPosition.x + xOffSet;

       transform.localPosition = new Vector3 
       (newXPos,yThrow);
                                             
       
        
    }
}
