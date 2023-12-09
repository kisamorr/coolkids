using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    public Button exitButton;
    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        exitButton.onClick.AddListener(exitGame);
        restartButton.onClick.AddListener(restartGame);
    }

    public void restartGame()
    {
        SceneManager.LoadScene("ReyesHouse");
        GameManager.instance.PauseMenu.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
