using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public int levelToLoad;
    public AudioSource audioClip;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetTrigger("Fadein");
        audioClip.Play();
    }

    public void PlaySound()
    {
        audioClip.Play();
    }

    public void FadeToNext()
    {
        FadeComplete(SceneManager.GetActiveScene().buildIndex + 1);
        audioClip.Play();
    }

    public void ToStart()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
        audioClip.Play();
    }

    public void FadeComplete(int levelIndex)
    {
        levelToLoad = levelIndex;

        SceneManager.LoadScene(levelToLoad);
    }
}
