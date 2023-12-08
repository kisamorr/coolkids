using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ToSkies : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public LevelChanger levelChanger;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerMovement.move.Disable();
            levelChanger.animator.SetTrigger("Fadeout");
        }
    }
}
