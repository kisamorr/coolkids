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
    public GameObject PauseMenu;
    public int itemsObtained = 0;
    public int notesObtained = 0;

    public Button TaskManagerApp;
    public Button TaskManagerAppExit;
    public Button NotesApp;
    public Button NotesAppExit;
    public Button InventoryApp;
    public Button InventoryAppExit;
    public GameObject TaskManagerOpen;
    public GameObject NotesOpen;
    public GameObject InventoryOpen;
    public GameObject Phone, PhoneNotifIcon, TaskManagerNotifIcon, NoteNotifIcon, InventoryNotifIcon;
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

        TaskManagerApp.onClick.AddListener(openTaskManagerApp);
        TaskManagerAppExit.onClick.AddListener(closeTaskManagerApp);
        NotesApp.onClick.AddListener(openNotesApp);
        NotesAppExit.onClick.AddListener(closeNotesApp);
        InventoryApp.onClick.AddListener(openInventoryApp);
        InventoryAppExit.onClick.AddListener(closeInventoryApp);
    }

    void Update()
    {
        emotionBar.fillAmount = currentEmotion/maxEmotion;

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (PauseMenu.activeInHierarchy) // exits pause menu
            {
                print("active");
                PauseMenu.SetActive(false);

                if (dialogueSystem.activeInHierarchy)
                {
                    Phone.SetActive(false);
                }
                else
                {
                    Phone.SetActive(true);
                }
            }

            else if (!PauseMenu.activeInHierarchy) // opens pause menu
            {
                PauseMenu.SetActive(true);

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

    public void openTaskManagerApp()
    {
        TaskManagerOpen.SetActive(true);

        if (TaskManagerNotifIcon.activeInHierarchy)
        {
            TaskManagerNotifIcon.SetActive(false);
        }
    }

    public void closeTaskManagerApp()
    {
        TaskManagerOpen.SetActive(false);
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

    public void openInventoryApp()
    {
        InventoryOpen.SetActive(true);

        if (InventoryNotifIcon.activeInHierarchy)
        {
            InventoryNotifIcon.SetActive(false);
        }
    }

    public void closeInventoryApp()
    {
        InventoryOpen.SetActive(false);
    }
}
