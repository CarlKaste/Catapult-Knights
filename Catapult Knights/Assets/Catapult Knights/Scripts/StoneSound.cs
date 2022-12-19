using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource rockAudioSource;

    // Detta skript spelar upp ett ljud varje gång en sten från vagnen träffar marken
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            rockAudioSource.Play();
        }
    }
}
