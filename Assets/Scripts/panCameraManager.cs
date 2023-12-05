using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panCameraManager : MonoBehaviour
{
    public GameObject panCamera, mainCamera, mainCharacter;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mainCharacter.transform.rotation = Quaternion.Euler(0, 0, 0);
            panCamera.SetActive(true);
            mainCamera.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mainCharacter.transform.rotation = Quaternion.Euler(0, 90, 0);
            panCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
    }
}
