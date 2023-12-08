using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTracker : MonoBehaviour
{
    public AudioSource[] soundFX;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            soundFX[0].Play();
        }
    }
}
