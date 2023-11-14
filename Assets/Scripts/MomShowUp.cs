using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomShowUp : MonoBehaviour
{
    public GameObject collectible1, collectible2, collectible3, momObject;

    // Update is called once per frame
    void Update()
    {
        if (!collectible1.activeInHierarchy && !collectible2.activeInHierarchy && !collectible3.activeInHierarchy)
        {
            momObject.SetActive(true);
        }
    }
}
