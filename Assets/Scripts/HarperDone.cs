using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarperDone : MonoBehaviour
{
    public StoryTrigger storyTrigger;
    public ToReyesHouseRedux toReyesHouseRedux;

    // Update is called once per frame
    void Update()
    {
        if (storyTrigger.dialogueFinished == true)
        {
            toReyesHouseRedux.SceneChangeDefault();
        }
    }
}
