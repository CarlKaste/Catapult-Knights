using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultTurnHandle : MonoBehaviour
{
    [SerializeField]
    private Transform catapultReference;

    [SerializeField]
    private Transform rightHandGrab;

    [SerializeField]
    private float rotationSpeed;

    private Vector3 rotation;

    public void CatapultLeftTurnHandle()
    {
        rotation = new Vector3(0f, 1f, 0f) * Time.deltaTime * rotationSpeed;
        catapultReference.eulerAngles += rotation;
    }

    public void CatapultRightTurnHandle()
    {
        rotation = new Vector3(0f, 1f, 0f) * Time.deltaTime * rotationSpeed;
        catapultReference.eulerAngles -= rotation;
    }
}
