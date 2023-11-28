using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harperPosition : MonoBehaviour
{
    public GameObject harper, reyes;

    void Update()
    {
        harper.transform.position = reyes.transform.localPosition + new Vector3(-2.75f, 0.0f, -1.0f);
        harper.transform.rotation = reyes.transform.rotation;
    }
}
