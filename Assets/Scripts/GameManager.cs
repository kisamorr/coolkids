using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Image[] imageSlots;
    public InventoryItem[] inventoryItems;

    public GameObject InventorySystem;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        // inventory can be opened and closed
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (InventorySystem.activeInHierarchy)
            {
                print("active");
                InventorySystem.SetActive(false);
            }

            else if (!InventorySystem.activeInHierarchy)
            {
                InventorySystem.SetActive(true);
            }
        }
    }
}
