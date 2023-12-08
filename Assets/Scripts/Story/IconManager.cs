using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    public static IconManager instance;
    public GameObject iconObject;
    public Image iconRenderer;

    public IconLibrary iconLibrary;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        Debug.LogWarning("Initialized IconManager with " + (iconObject != null));
    }

    public void SetIcon(string characterName)
    {
        foreach (Icon icon in iconLibrary.icons)
        {
            if (icon.name == characterName)
            {
                if (iconObject == null)
                {
                    Debug.LogError("iconObject was null");
                }

                if (icon == null)
                {
                    Debug.LogError("icon was null");
                }

                iconRenderer.sprite = icon.image;
                Debug.Log(characterName);
                return;
            }
        }
        Debug.LogError($"Tried to active icon {characterName} but couldn't find it");
    }
}
