using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHarperTrigger : MonoBehaviour
{
    public GameObject Harper;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Harper.SetActive(true);
        }
    }
}
