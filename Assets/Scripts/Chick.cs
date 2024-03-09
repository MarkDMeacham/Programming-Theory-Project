using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : Animal
{
    private string animalName;

    private void Awake()
    {
        animalName = "Soka";
        speakAudio = GetComponent<AudioSource>();
        animalRb = GetComponent<Rigidbody>();
    }

    protected override void DisplayName()
    {
        GameManager.Instance.DisplayName(animalName);
    }
}
