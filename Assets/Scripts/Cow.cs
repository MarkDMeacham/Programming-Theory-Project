using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
    private void Awake()
    {
        speakAudio = GetComponent<AudioSource>();
        animalRb = GetComponent<Rigidbody>();
    }

    public override void Jump()
    {
        animalRb.AddTorque(transform.right * jumpSpeed * -1.0f, ForceMode.Impulse);
    }
}
