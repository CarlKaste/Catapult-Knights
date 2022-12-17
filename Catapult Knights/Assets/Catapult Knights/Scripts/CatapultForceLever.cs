using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultForceLever : MonoBehaviour
{
    [SerializeField]
    private Catapult catapultReference;

    [SerializeField]
    private Transform leverReference;

    private int leverPositionSelected;

    private Vector3 leverOffsetPos1 = new Vector3(0.12f, 0.1f, 0f);
    private Vector3 leverOffsetPos2 = new Vector3(0f, 0.1f, 0f);
    private Vector3 leverOffsetPos3 = new Vector3(-0.12f, 0.1f, 0f);

    void Start()
    {
        leverReference.position = transform.position + leverOffsetPos1;
        leverPositionSelected = 1;
        catapultReference.projectileForce = 4500;
    }

    public void ChangeLeverPosition()
    {
        int totalLeverPositions = 3;
        leverPositionSelected++;

        if(leverPositionSelected > totalLeverPositions)
        {
            leverPositionSelected = 1;
        }

        if(leverPositionSelected == 1)
        {
            catapultReference.projectileForce = 4500;
            leverReference.position = transform.position + leverOffsetPos1;
        }

        if (leverPositionSelected == 2)
        {
            catapultReference.projectileForce = 5250;
            leverReference.position = transform.position + leverOffsetPos2;
        }

        if (leverPositionSelected == 3)
        {
            catapultReference.projectileForce = 6000;
            leverReference.position = transform.position + leverOffsetPos3;
        }
    }
}