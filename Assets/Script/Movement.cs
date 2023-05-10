using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    [SerializeField] float xRange = 5f;
    
    void Update()
    {
       float xThrow = Input.GetAxis("Horizontal");
       float yThrow = Input.GetAxis("Vertical");

       float xOffSet = xThrow * Time.deltaTime * controlSpeed;
       float rawXPos = transform.localPosition.x + xOffSet;
       float clampedXPos = Mathf.Clamp(rawXPos,-xRange,xRange);

       float yOffSet = yThrow * Time.deltaTime * controlSpeed;
       float newYPos = transform.localPosition.y + yOffSet;

       transform.localPosition = new Vector3 
       (clampedXPos,newYPos);
                                             
       
        
    }
}
