using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource hitSound;

    private void OnCollisionEnter(Collision collision)
    {
        hitSound.Play();
    }
}
