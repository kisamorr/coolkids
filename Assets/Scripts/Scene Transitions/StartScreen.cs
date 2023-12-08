using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public Button start, exit, controls;
    //public Panel controlPanel;

    void Start()
    {
        start.onClick.AddListener(startGame);
        exit.onClick.AddListener(quitGame);
        //controls.onClick.AddListener(viewControls);
    }

    void startGame()
    {
        SceneManager.LoadScene("ReyesHouse", LoadSceneMode.Single);
    }

    void quitGame()
    {
        Application.Quit();
    }

    /*void viewControls()
    {
        controlPanel.SetActive(true);
    }*/
}
