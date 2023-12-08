using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ToStart : MonoBehaviour
{
    public StoryManager storyManager;
    public PlayerMovement playerMovement;
    public LevelChanger levelChanger;

    void Update()
    {
        if (storyManager.storyDone == true)
        {
            playerMovement.move.Disable();
            levelChanger.animator.SetTrigger("Fade2Start");
        }
    }

    /*private void OnTriggerEnter(Collider collision)
    {
        if (storyTrigger.dialogueFinished = true && collision.gameObject.tag == "Player")
        {
            //playerMovement.move.Disable();
            levelChanger.animator.SetTrigger("Fade2Start");
        }
    }*/
}
