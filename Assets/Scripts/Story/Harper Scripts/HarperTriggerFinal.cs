using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperTriggerFinal : MonoBehaviour
{
    public GameObject Harper;
    public HarperTrigger2 harperTrigger2;

    private void OnTriggerEnter(Collider collider)
    {
        if (harperTrigger2.isActivated && collider.gameObject.tag == "Player")
        {
            Harper.SetActive(true);
        }
    }
}
