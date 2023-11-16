using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class OptionUI : MonoBehaviour
{
    public TextMeshProUGUI optionText;
    //public Image selectionIndicator;
    //public Image backgroundImage;

    // Start is called before the first frame update
    public void SetOptionText(string text)
    {
        optionText.text = text;
    }

    public void SetSelected(bool selected)
    {
        if (selected)
        {
            //selectionIndicator.gameObject.SetActive(true);
            //backgroundImage.color = new Color(1, .35f, 0);
        }
        else
        {
            //selectionIndicator.gameObject.SetActive(false);
            //backgroundImage.color = Color.white;
        }
    }

    public void SetVisible(bool visible)
    {
        //Debug.LogError($"option {gameObject.name} set to {visible}");
        gameObject.SetActive(visible);
        //selectionIndicator.gameObject.SetActive(visible);
        //backgroundImage.gameObject.SetActive(visible);
    }
}
