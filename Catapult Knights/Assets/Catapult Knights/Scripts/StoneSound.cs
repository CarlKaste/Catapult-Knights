using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource rockAudioSource;

    // Detta skript spelar upp ett ljud varje g�ng en sten fr�n vagnen tr�ffar marken
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            rockAudioSource.Play();
        }
    }
}
