using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperManager : MonoBehaviour
{
    public GameObject harper1, harper2, harper3, harper4, harper5, harper6, harperFollow;

    private void Update()
    {
        if (harper1.activeInHierarchy || harper2.activeInHierarchy || harper3.activeInHierarchy || harper4.activeInHierarchy || harper5.activeInHierarchy || harper6.activeInHierarchy)
        {
            harperFollow.SetActive(false);
        }
    }
}
