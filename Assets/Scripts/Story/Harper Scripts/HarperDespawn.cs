using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperDespawn : MonoBehaviour
{
    public GameObject Harper, harperFollow;
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            harperFollow.SetActive(true);
            Harper.SetActive(false);
        }
    }
}
