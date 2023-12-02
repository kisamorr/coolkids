using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;

public class StoryTrigger : MonoBehaviour
{
    public StoryTrigger instance; //watermelon
    public GameObject visualCue;
    private bool playerInRange;
    public bool dialogueFinished = false;
    public TextAsset inkJson;
    public PlayerInputActions playerControls;
    public InputAction interact;
    public StoryManager StoryManager;

    public Note note;
    public Collectible collectible;
    public bool noteInvolved;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        playerControls = new PlayerInputActions();
    }

    private void OnEnable() //Must be used for the new input system to work properly
    {
        interact = playerControls.Player.Interact;
        interact.Enable();
    }

    private void OnDisable() //Must be used for the new input system to work properly
    {
        interact.Disable();
    }

    private void Update()
    {
        if (collectible.isObtained == true && playerInRange)
        {
            visualCue.SetActive(true);

            if (interact.IsPressed())
            {
                StoryManager.Instance.EnterStoryMode(inkJson);
            }
        }

        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        playerInRange = false;
        //StoryManager.Instance.ExitStoryMode();

        // if the player receives a note from this interaction (basically all interactions except arguments)
        // noteInvolved MUST BE CHECKED IN EDITOR TO DETERMINE THIS
        if (noteInvolved == true)
        {
            collectible.GiveItem();
            collectible.isObtained = false;
            note.ObtainNote();
            dialogueFinished = true;
        }
    }

    public void StoryNote()
    {
        print("story note");
        if (noteInvolved == true)
        {
            collectible.GiveItem();
            collectible.isObtained = false;
            note.ObtainNote();
            dialogueFinished = true;
        }
    }
}
