using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject introductionScreen;

    [SerializeField]
    private GameObject firstCatapultInstructionScreen;

    [SerializeField]
    private GameObject secondCatapultInstructionScreen;

    [SerializeField]
    private GameObject gameInstructionScreen;

    public void WinGame()
    {
        Debug.Log("Seger!");
    }

    public void Introduction()
    {

    }
}
