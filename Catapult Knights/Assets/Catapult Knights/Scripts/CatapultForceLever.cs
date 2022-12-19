using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultForceLever : MonoBehaviour
{
    [SerializeField]
    private Catapult catapultReference;

    [SerializeField]
    private Transform leverReference;

    [SerializeField]
    private float lowestProjectileForce;

    [SerializeField]
    private float mediumProjectileForce;

    [SerializeField]
    private float highestProjectileForce;

    private int leverPositionSelected; // H�ller koll p� i vilket l�ge spaken befinner sig i

    private Vector3 leverOffsetPos1 = new Vector3(0.12f, 0.1f, 0f); //Offsetposition f�r den lilla kraftspaken
    private Vector3 leverOffsetPos2 = new Vector3(0f, 0.1f, 0f); //Offsetposition f�r den lilla kraftspaken
    private Vector3 leverOffsetPos3 = new Vector3(-0.12f, 0.1f, 0f); //Offsetposition f�r den lilla kraftspaken

    void Start() // I starten f�r spaken sin: 
    {
        leverReference.position = transform.position + leverOffsetPos1; // position n�rmast spelaren
        leverPositionSelected = 1; // sitt l�ge
        catapultReference.projectileForce = lowestProjectileForce; // sitt kraftl�ge (det l�gsta)
    }

    public void ChangeLeverPosition()
    {
        int totalLeverPositions = 3;
        leverPositionSelected++; // Varje g�ng man aktiverar spaken �ndras l�get den �r i

        if(leverPositionSelected > totalLeverPositions) // Kollar om man g�tt �ver det totala m�ngden l�gen
        {
            leverPositionSelected = 1;
        }

        if(leverPositionSelected == 1) 
        {
            catapultReference.projectileForce = lowestProjectileForce; // Nytt kraftl�ge
            leverReference.position = transform.position + leverOffsetPos1; // Ny spakpossition
        }

        if (leverPositionSelected == 2)
        {
            catapultReference.projectileForce = mediumProjectileForce; // Nytt kraftl�ge
            leverReference.position = transform.position + leverOffsetPos2; // Ny spakpossition
        }

        if (leverPositionSelected == 3)
        {
            catapultReference.projectileForce = highestProjectileForce; // Nytt kraftl�ge
            leverReference.position = transform.position + leverOffsetPos3; // Ny spakpossition
        }
    }
}
