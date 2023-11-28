using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperTrigger : MonoBehaviour
{
    public Collider[] colliders;
    public GameObject[] harper;

    private void OnTriggerEnter(string[] colliders)
    {
        foreach (string collider in colliders)
        {
            if (collider.gameObject.tag == "Player")
            {
                harper[0].SetActive(true);
            }
        }
        
    }

    //TODO: make harper run over to desired position when hitting collider

}
