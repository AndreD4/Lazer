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

       transform.localPosition = new Vector3 (transform.localPosition.x,
                                              transform.localPosition.y,
                                              transform.localPosition.z);
                                             
       
        
    }
}
