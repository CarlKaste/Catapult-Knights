using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultTurnHandle : MonoBehaviour
{
    // Detta skript roterar katapulten
    [SerializeField]
    private Transform catapultReference;

    [SerializeField]
    private Transform rightHandGrab;

    [SerializeField]
    private float rotationSpeed;

    private Vector3 rotation;

    public void CatapultLeftTurnHandle() // F�r katapulten att sm�tt vridas medsols
    {
        rotation = new Vector3(0f, 1f, 0f) * Time.deltaTime * rotationSpeed;
        catapultReference.eulerAngles += rotation;
    }

    public void CatapultRightTurnHandle() // F�r katapulten att sm�tt vridas motsols
    {
        rotation = new Vector3(0f, 1f, 0f) * Time.deltaTime * rotationSpeed;
        catapultReference.eulerAngles -= rotation;
    }
}
