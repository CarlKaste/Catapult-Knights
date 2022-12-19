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

    private int leverPositionSelected; // Håller koll på i vilket läge spaken befinner sig i

    private Vector3 leverOffsetPos1 = new Vector3(0.12f, 0.1f, 0f); //Offsetposition för den lilla kraftspaken
    private Vector3 leverOffsetPos2 = new Vector3(0f, 0.1f, 0f); //Offsetposition för den lilla kraftspaken
    private Vector3 leverOffsetPos3 = new Vector3(-0.12f, 0.1f, 0f); //Offsetposition för den lilla kraftspaken

    void Start() // I starten får spaken sin: 
    {
        leverReference.position = transform.position + leverOffsetPos1; // position närmast spelaren
        leverPositionSelected = 1; // sitt läge
        catapultReference.projectileForce = lowestProjectileForce; // sitt kraftläge (det lägsta)
    }

    public void ChangeLeverPosition()
    {
        int totalLeverPositions = 3;
        leverPositionSelected++; // Varje gång man aktiverar spaken ändras läget den är i

        if(leverPositionSelected > totalLeverPositions) // Kollar om man gått över det totala mängden lägen
        {
            leverPositionSelected = 1;
        }

        if(leverPositionSelected == 1) 
        {
            catapultReference.projectileForce = lowestProjectileForce; // Nytt kraftläge
            leverReference.position = transform.position + leverOffsetPos1; // Ny spakpossition
        }

        if (leverPositionSelected == 2)
        {
            catapultReference.projectileForce = mediumProjectileForce; // Nytt kraftläge
            leverReference.position = transform.position + leverOffsetPos2; // Ny spakpossition
        }

        if (leverPositionSelected == 3)
        {
            catapultReference.projectileForce = highestProjectileForce; // Nytt kraftläge
            leverReference.position = transform.position + leverOffsetPos3; // Ny spakpossition
        }
    }
}
