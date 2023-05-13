using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    [SerializeField] float xRange = 5f;
    [SerializeField] float yRange = 5f;

    [SerializeField] float positionPitch = -2f;

    float xThrow,yThrow;
    
    void Update()
  {
    ProcessTranslation();
    ProcessRotation();

  }

    void ProcessRotation()
    { 
      float pitch = transform.localPosition.y * positionPitch;
      float yaw = 0f;
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
