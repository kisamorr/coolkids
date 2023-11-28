using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperTrigger : MonoBehaviour
{
    public Collider[] collider;
    public GameObject[] harper;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //harper.gameObject.SetActive();
        }
    }

    //TODO: make harper run over to desired position when hitting collider

}
