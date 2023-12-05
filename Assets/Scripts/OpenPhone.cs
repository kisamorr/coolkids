using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPhone : MonoBehaviour
{
    public Button openPhone;
    public GameObject PauseMenu, phone;

    // Start is called before the first frame update
    void Start()
    {
        openPhone.onClick.AddListener(phoneOpen);
    }

    public void phoneOpen()
    {
        PauseMenu.SetActive(true);
        phone.SetActive(false);
    }
}
