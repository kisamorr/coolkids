using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCollider : MonoBehaviour
{
    public ArgumentTrigger argumentTrigger;
    public GameObject getOut;

    void Update()
    {
        if (argumentTrigger.dialogueFinished == true)
        {
            getOut.SetActive(true);
        }
    }
}
