using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cow : Animal
{
    private string animalName;

    private void Awake()
    {
        animalName = "Bruce";
        speakAudio = GetComponent<AudioSource>();
        animalRb = GetComponent<Rigidbody>();
    }

    // POLYMORPHISM
    public override void Jump()
    {
        animalRb.AddTorque(transform.right * jumpSpeed * -1.0f, ForceMode.Impulse);
    }

    protected override void DisplayName()
    {
        GameManager.Instance.DisplayName(animalName);
    }
}
