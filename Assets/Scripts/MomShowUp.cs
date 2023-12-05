using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomShowUp : MonoBehaviour
{
    public StoryTrigger titaTrigger, guysTrigger, mariaTrigger;
    public GameObject momObject;
    public GameObject task1, task2, task3, task4;

    // Update is called once per frame
    void Update()
    {
        if (titaTrigger.dialogueFinished && guysTrigger.dialogueFinished && mariaTrigger.dialogueFinished)
        {
            momObject.SetActive(true);
            task1.SetActive(false);
            task2.SetActive(false);
            task3.SetActive(false);
            task4.SetActive(true);
        }
    }
}
