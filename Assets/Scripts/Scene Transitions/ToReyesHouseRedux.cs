using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToReyesHouseRedux : MonoBehaviour
{
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("ReyesHouseRedux", LoadSceneMode.Single);
        }
    }
}
