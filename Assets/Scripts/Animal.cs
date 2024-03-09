using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected AudioSource speakAudio;
    protected Rigidbody animalRb;

    [SerializeField]
    protected float jumpSpeed;

    private void OnMouseDown()
    {
        Speak();
        Jump();
    }

    private void Speak()
    {
        speakAudio.Play();
    }

    public virtual void Jump()
    {
        animalRb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
    }
}
