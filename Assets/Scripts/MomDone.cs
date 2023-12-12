using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomDone : MonoBehaviour
{
    public ArgumentTrigger argumentTrigger;
    public ToHidingPlace toHidingPlace;

    // Update is called once per frame
    void Update()
    {
        if (argumentTrigger.dialogueFinished == true)
        {
            toHidingPlace.SceneChangeDefault();
        }
    }
}
