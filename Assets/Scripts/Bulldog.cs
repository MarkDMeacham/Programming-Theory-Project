using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulldog : Animal
{
    private void Awake()
    {
        speakAudio = GetComponent<AudioSource>();
        animalRb = GetComponent<Rigidbody>();
    }
}
