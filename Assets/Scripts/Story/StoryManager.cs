using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Ink.Runtime;
using System.Linq;
using TMPro;
//using UnityEditor.Experimental.GraphView;
using System.Runtime.ExceptionServices;

public class StoryManager : MonoBehaviour
{
    public static StoryManager Instance;
    public TextAsset inkJson;
    public TextMeshProUGUI rightText;
    public GameObject storyPanel;
    //public Animator leftAnimator, rightAnimator;
    public bool storyIsPlaying { get; private set; }
    //public BackgroundLibrary backgroundLibrary;

    public Story ourStory;
    public OptionUI[] optionUIs;
    int currentOption;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        storyIsPlaying = false;
        storyPanel.SetActive(false);
        ourStory = new Story(inkJson.text);
        AdvanceStory();
    }

    // Update is called once per frame
    void Update()
    {
        string[] options = new string[3];

        if (ourStory.canContinue)
        {
            options[0] = "Continue";
        }
        else
        {
            for (int i = 0; i < ourStory.currentChoices.Count; i++)
            {
                options[i] = ourStory.currentChoices[i].text;
            }
        }

        SetupOptions(options);
    }

    public void EnterStoryMode(TextAsset inkJSON)
    {
        ourStory = new Story(inkJSON.text);
        storyIsPlaying = true;
        storyPanel.SetActive(true);
        currentOption = 0;
        AdvanceStory();
    }

    public void ExitStoryMode()
    {
        storyIsPlaying = false;
        storyPanel.SetActive(false);
        //storyText.text = "";
    }

    void SetupOptions(string[] options)
    {
        for (int i = 0; i < 3; i++)
        {
            if (options[i] == null)
            {
                optionUIs[i].SetVisible(false);
            }
            else
            {
                optionUIs[i].SetVisible(true);
                optionUIs[i].SetOptionText(options[i]);
                optionUIs[i].SetSelected(i == currentOption);
            }
        }
    }

    public void OnOptionClicked(int index)
    {
        Debug.LogError(index + "npt Work");
        rightText.text = "";

        if (ourStory.canContinue)
        {
            AdvanceStory();
        }
        else
        {
            ourStory.ChooseChoiceIndex(index);
            AdvanceStory();
        }
        currentOption = 0;
    }

    void AdvanceStory()
    {
        string text = ourStory.Continue();
        //Animator currentAnimator = null;
        //GameObject currentBackground = null;

        foreach (string tag in ourStory.currentTags)
        {
            bool didSomething = false;

            rightText.text = text;
            rightText.color = Color.red;
            didSomething = true;

            /*if (tag.StartsWith("sound;"))
            {
                // "sound;music_octo"
                string[] parts = tag.Split(';');
                // ["sound", "music_octo"]
                string soundName = parts[1];
                // "music_octo"

                SoundManager.instance.PlaySound(soundName);
                Debug.Log("you should be hearing something here");
                Debug.Log(soundName);
                didSomething = true;
            }

            if (tag.StartsWith("setting;"))
            {
                string[] parts = tag.Split(';');
                string bgName = parts[1];

                BackgroundManager.instance.SetBackground(bgName);
                Debug.Log("background should have changed to" + bgName);
                didSomething = true;
            }

            if (tag.StartsWith("anim;"))
            {
                string[] parts = tag.Split(';');
                string animName = parts[1];

                if (currentAnimator != null)
                {
                    currentAnimator.SetTrigger(animName);
                    Debug.Log(animName);
                }
                else
                {
                    Debug.LogError("Anim tag found but without a character to use");
                }

                didSomething = true;
            }*/

            if (!didSomething)
            {
                Debug.LogError("$Couldn't interpret tag");
            }
        }
    }
}