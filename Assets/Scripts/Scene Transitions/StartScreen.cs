using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public Button start, exit, controls, controlsExit;
    public GameObject controlPanel;
    public Animator fadeTransitions;
    public AudioSource audioClip;

    void Start()
    {
        start.onClick.AddListener(startGame);
        exit.onClick.AddListener(quitGame);
        controls.onClick.AddListener(viewControls);
        controlsExit.onClick.AddListener(exitControls);
    }

    void startGame()
    {
        fadeTransitions.SetTrigger("FadeOut2");
        audioClip.Play();
    }

    void quitGame()
    {
        Application.Quit();
        audioClip.Play();
    }

    void viewControls()
    {
        controlPanel.SetActive(true);
        audioClip.Play();
    }

    void exitControls()
    {
        controlPanel.SetActive(false);
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("ReyesHouse", LoadSceneMode.Single);
    }
}
