using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : Animal
{
    private void Awake()
    {
        speakAudio = GetComponent<AudioSource>();
        animalRb = GetComponent<Rigidbody>();
    }
}
