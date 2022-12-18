using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger : MonoBehaviour
{
    [SerializeField]
    private Rigidbody flagRigidbody;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            flagRigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
