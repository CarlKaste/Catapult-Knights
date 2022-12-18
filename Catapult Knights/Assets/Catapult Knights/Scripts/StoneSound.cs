using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource rockAudioSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            rockAudioSource.Play();
        }
    }
}
