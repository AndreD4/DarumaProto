using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float thrustPower = 1f;
    [SerializeField] float rotationPower = 1f;
    Rigidbody myRigidbody;
    AudioSource audioSource;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
        audioSource.Play(); 
        myRigidbody.AddRelativeForce(Vector3.up * thrustPower * Time.deltaTime);
      }
      else if (!audioSource.isPlaying)
      {
        audioSource.Stop();
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
    myRigidbody.freezeRotation = false; // unfreezing rotation so the physics system can take over

  }
}
