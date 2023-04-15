using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float thrustPower = 1f;
    [SerializeField] float rotationPower = 1f;
    Rigidbody myRigidbody;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProccessThrust();
        ProccessRotation();
    }

    void ProccessThrust()
    {
      if (Input.GetKey(KeyCode.Space))
      {
        myRigidbody.AddRelativeForce(Vector3.up * thrustPower * Time.deltaTime);
      }
    }

    void ProccessRotation()
    {
      if (Input.GetKey(KeyCode.A))
    {
      ApplyRotation(rotationPower);
    }

    else if (Input.GetKey(KeyCode.D))
      {
          ApplyRotation(-rotationPower);
      }
    }

    void ApplyRotation(float rotationThisFrame)
  {
    myRigidbody.freezeRotation = true; // freezing rotation so i can manually rotate
    transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
  }
}
