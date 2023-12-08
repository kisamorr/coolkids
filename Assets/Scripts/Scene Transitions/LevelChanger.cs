using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public int levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetTrigger("Fadein");
    }

    public void FadeToNext()
    {
        FadeComplete(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ToStart()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }

    public void FadeComplete(int levelIndex)
    {
        levelToLoad = levelIndex;

        SceneManager.LoadScene(levelToLoad);
    }
}
