using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource hitSound;

    // Detta skript spelar upp ett ljud varje g�ng som en projektil tr�ffar ett f�rem�l
    private void OnCollisionEnter(Collision collision)
    {
        hitSound.Play();
    }
}
