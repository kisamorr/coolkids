using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperManager : MonoBehaviour
{
    public GameObject harper1, harper2, harper3, harperFollow;

    private void Update()
    {
        if (harper1.activeInHierarchy || harper2.activeInHierarchy || harper3.activeInHierarchy)
        {
            harperFollow.SetActive(false);
        }
    }
}
