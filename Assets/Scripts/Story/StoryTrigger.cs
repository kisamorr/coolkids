using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;

public class StoryTrigger : MonoBehaviour
{
    public StoryTrigger instance;
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

    private void OnEnable()
    {
        interact = playerControls.Player.Interact;
        interact.Enable();
    }

    private void OnDisable()
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

        if (StoryManager.storyDone == true && playerInRange)
        {
            visualCue.SetActive(false);
            StoryNote();
            StoryManager.storyDone = false;
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
    }

    public void StoryNote()
    {
        collectible.GiveItem();
        collectible.isObtained = false;
        dialogueFinished = true;

        if (noteInvolved == true)
        {
            note.ObtainNote();
        }
    }
}
