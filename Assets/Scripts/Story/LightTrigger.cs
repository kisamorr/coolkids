using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public static LightTrigger instance;
    public GameObject[] lightIndicator;
   
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
           //lightIndicator.SetActive(true);
        }
    }
}
