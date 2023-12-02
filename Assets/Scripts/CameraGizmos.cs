using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGizmos : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 1));

    }
}
