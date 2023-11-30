using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperDespawn : MonoBehaviour
{
    public GameObject Harper, HarperCollider, harperFollow;
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Harper.SetActive(false);
            HarperCollider.SetActive(false);
            harperFollow.SetActive(true);
        }
    }
}
