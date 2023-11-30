using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperTrigger2 : MonoBehaviour
{
    public bool isActivated = false;
    public GameObject Harper;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Harper.SetActive(true);
            isActivated = true;
        }
    }
}
