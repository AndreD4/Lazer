using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    
    void Update()
    {
       float xThrow = Input.GetAxis("Horizontal");
       float yThrow = Input.GetAxis("Vertical");

       float xOffSet = xThrow * Time.deltaTime * controlSpeed;
       float newXPos = transform.localPosition.x + xOffSet;

       float yOffSet = yThrow * Time.deltaTime * controlSpeed;
       float newYPos = transform.localPosition.x + yOffSet;

       transform.localPosition = new Vector3 
       (newXPos,newYPos);
                                             
       
        
    }
}
