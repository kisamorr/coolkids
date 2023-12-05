using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskEnable : MonoBehaviour
{
    public GameObject nextTask, taskCheck;
    public bool additionalTask;
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            taskCheck.SetActive(true);
            if (additionalTask == true)
            {
                nextTask.SetActive(true);
            }
        }
    }
}
