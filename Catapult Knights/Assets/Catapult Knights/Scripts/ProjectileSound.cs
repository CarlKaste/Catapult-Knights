using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource hitSound;

    // Detta skript spelar upp ett ljud varje gång som en projektil träffar ett föremål
    private void OnCollisionEnter(Collision collision)
    {
        hitSound.Play();
    }
}
