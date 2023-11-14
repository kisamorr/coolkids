using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomShowUp : MonoBehaviour
{
    public StoryTrigger titaTrigger, guysTrigger, mariaTrigger;
    public GameObject momObject;

    // Update is called once per frame
    void Update()
    {
        if (titaTrigger.dialogueFinished && guysTrigger.dialogueFinished && mariaTrigger.dialogueFinished)
        {
            momObject.SetActive(true);
        }
    }
}
