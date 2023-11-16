using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button MessagingApp;
    public Button MessagingAppExit;
    public Button NotesApp;
    public Button NotesAppExit;
    public GameObject MessagingOpen;
    public GameObject NotesOpen;


    // Start is called before the first frame update
    void Start()
    {
        MessagingApp.onClick.AddListener(openMessagingApp);
        MessagingAppExit.onClick.AddListener(closeMessagingApp);
        NotesApp.onClick.AddListener(openNotesApp);
        NotesAppExit.onClick.AddListener(closeNotesApp);
    }

    public void openMessagingApp()
    {
        MessagingOpen.SetActive(true);
    }

    public void closeMessagingApp()
    {
        MessagingOpen.SetActive(false);
    }

    public void openNotesApp()
    {
        NotesOpen.SetActive(true);
    }

    public void closeNotesApp()
    {
        NotesOpen.SetActive(false);
    }
}
