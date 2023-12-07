using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperTrigger : MonoBehaviour
{
    public GameObject Harper, StartCollider, EndCollider;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Harper.SetActive(true);
            StartCollider.SetActive(false);
            EndCollider.SetActive(true);
        }
    }

    //TODO: make harper run over to desired position when hitting collider

}
