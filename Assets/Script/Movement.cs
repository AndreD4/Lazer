using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    [SerializeField] float xRange = 5f;
    [SerializeField] float yRange = 5f;

    [SerializeField] float positionPitch = -2f;
    [SerializeField] float controlPitch = -10f;
    [SerializeField] float positionYaw = 2f;
    [SerializeField] float controlRoll = 10f;
    
  

    float xThrow,yThrow;
    
    void Update()
  {
    ProcessTranslation();
    ProcessRotation();

  }

    void ProcessRotation()
    { 
      float pitchToPostion = transform.localPosition.y * positionPitch;
      float pitchToControlThrow = yThrow * controlPitch;

      float yawToPosition = transform.localPosition.x * positionYaw;
      //float rollToThrow = transform.localRotation.x * controlRoll + xThrow;


      float pitch = pitchToPostion + pitchToControlThrow;
      float yaw = yawToPosition;
      float roll = 0f;

      transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    void ProcessTranslation()
  {
    xThrow = Input.GetAxis("Horizontal");
    yThrow = Input.GetAxis("Vertical");

    float xOffSet = xThrow * Time.deltaTime * controlSpeed;
    float rawXPos = transform.localPosition.x + xOffSet;
    float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);

    float yOffSet = yThrow * Time.deltaTime * controlSpeed;
    float rawYPos = transform.localPosition.y + yOffSet;
    float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange);

    transform.localPosition = new Vector3
    (clampedXPos, clampedYPos);
  }
}
