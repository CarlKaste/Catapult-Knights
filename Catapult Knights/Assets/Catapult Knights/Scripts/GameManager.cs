using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    [SerializeField]
    private GameObject levelWonScreen;

    [SerializeField]
    private GameObject gameWonScreen;

    int selectedScreen;

    private void Start()
    {
        introductionScreen.SetActive(true);
        selectedScreen = 1;
    }

    private void Update()
    {
        if(selectedScreen == 1)
        {
            introductionScreen.SetActive(true);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(false);
        }
        if (selectedScreen == 2)
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(true);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(false);
        }
        if (selectedScreen == 3)
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(true);
            gameInstructionScreen.SetActive(false);
        }
        if (selectedScreen == 4)
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(true);
        }
        if (selectedScreen == 5)
        {
            introductionScreen.SetActive(false);
            firstCatapultInstructionScreen.SetActive(false);
            secondCatapultInstructionScreen.SetActive(false);
            gameInstructionScreen.SetActive(false);
        }
    }

    public void NextScreen()
    {
        selectedScreen++;
    }
    public void PreviousScreen()
    {
        selectedScreen--;
    }
    /*
    public void LevelWon()
    {
        levelWonScreen.SetActive(true);
    }
    
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    */
    public void GameWon()
    {
        gameWonScreen.SetActive(true);
    }
    public void EndGame()
    {
        gameWonScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }
}