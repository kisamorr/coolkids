using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ToReyesHouseRedux : MonoBehaviour
{
     public StoryTrigger storyTrigger;
    public PlayerMovement playerMovement;
    public LevelChanger levelChanger;

    void Update()
    {
        if (storyTrigger.dialogueFinished == true)
        {
            Debug.Log("Switched scenes.");
            playerMovement.move.Disable();
            levelChanger.animator.SetTrigger("Fadeout");
        }
    }
}
