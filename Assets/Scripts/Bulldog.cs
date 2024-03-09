using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulldog : Animal
{
    private string animalName;

    private void Awake()
    {
        animalName = "Spock";
        speakAudio = GetComponent<AudioSource>();
        animalRb = GetComponent<Rigidbody>();
    }

    protected override void DisplayName()
    {
        GameManager.Instance.DisplayName(animalName);
    }
}
