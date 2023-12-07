using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Image[] imageSlots;
    public InventoryItem[] inventoryItems;
    public TextMeshProUGUI[] noteSlots;

    public GameObject player;
    public GameObject InventorySystem;
    public int itemsObtained = 0;
    public int notesObtained = 0;

    public Button MessagingApp;
    public Button MessagingAppExit;
    public Button NotesApp;
    public Button NotesAppExit;
    public GameObject MessagingOpen;
    public GameObject NotesOpen;
    public GameObject Phone, PhoneNotifIcon, MessageNotifIcon, NoteNotifIcon;
    public GameObject dialogueSystem;

    public Image emotionBar;
    public float maxEmotion = 100f;
    public float currentEmotion;
    public bool emotionUpdating;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentEmotion = maxEmotion;
        emotionUpdating = false;

        MessagingApp.onClick.AddListener(openMessagingApp);
        MessagingAppExit.onClick.AddListener(closeMessagingApp);
        NotesApp.onClick.AddListener(openNotesApp);
        NotesAppExit.onClick.AddListener(closeNotesApp);
    }

    void Update()
    {
        emotionBar.fillAmount = currentEmotion/maxEmotion;
        // inventory can be opened and closed
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (InventorySystem.activeInHierarchy) // exits pause menu
            {
                print("active");
                InventorySystem.SetActive(false);
                Phone.SetActive(true);
                Time.timeScale = 1;
            }

            else if (!InventorySystem.activeInHierarchy) // opens pause menu
            {
                InventorySystem.SetActive(true);
                Time.timeScale = 0;

                if (PhoneNotifIcon.activeInHierarchy)
                {
                    PhoneNotifIcon.SetActive(false);
                }

                Phone.SetActive(false);
            }
        }
    }

    private void FixedUpdate()
    {
        if (!dialogueSystem.activeInHierarchy && currentEmotion < maxEmotion)
        {
            float emotionIncrease = 0.05f;
            currentEmotion = currentEmotion + emotionIncrease;

            if (currentEmotion < 0)
            {
                currentEmotion = 0;
            }
        }
    }

    public void openMessagingApp()
    {
        MessagingOpen.SetActive(true);

        if (MessageNotifIcon.activeInHierarchy)
        {
            MessageNotifIcon.SetActive(false);
        }
    }

    public void closeMessagingApp()
    {
        MessagingOpen.SetActive(false);
    }

    public void openNotesApp()
    {
        NotesOpen.SetActive(true);

        if (NoteNotifIcon.activeInHierarchy)
        {
            NoteNotifIcon.SetActive(false);
        }
    }

    public void closeNotesApp()
    {
        NotesOpen.SetActive(false);
    }
}
