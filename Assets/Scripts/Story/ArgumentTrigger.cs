using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;

public class ArgumentTrigger : MonoBehaviour
{
    public ArgumentTrigger instance;
    public GameObject visualCue;
    private bool playerInRange;
    public bool dialogueFinished = false;
    public TextAsset inkJson;
    public PlayerInputActions playerControls;
    public InputAction interact;
    public StoryManager StoryManager;

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
        if (playerInRange)
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
        StoryManager.Instance.ExitStoryMode();
    }
}