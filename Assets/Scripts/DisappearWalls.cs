using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearWalls : MonoBehaviour
{
    public GameObject disappearingWalls;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            disappearingWalls.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            disappearingWalls.SetActive(true);
        }
    }
}
