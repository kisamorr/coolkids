using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAppear : MonoBehaviour
{
    public GameObject exitCollider;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            exitCollider.SetActive(true);
        }
    }
}
