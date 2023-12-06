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
    public InputActionReference continueAction;
    public static StoryManager Instance;
    public LightTrigger lightTrigger;
    public TextAsset inkJson;
    //public TextAsset altInkJson;
    public TextMeshProUGUI rightText, leftText, midText, leftNameTagText, rightNameTagText;
    public Image rightProfile, leftProfile;
    public GameObject storyPanel, rightNameTag, leftNameTag;
    //public Animator leftAnimator, rightAnimator;
    public bool storyIsPlaying { get; private set; }
    public bool storyDone = false;
    public Story ourStory;
    public OptionUI[] optionUI;
    int currentOption;
    //public GameObject lights;

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

        continueAction.action.performed += (a) => OnOptionClicked(0);

    }

    // Update is called once per frame
    public void Update()
    {
        string[] options = new string[4];

        if (ourStory.canContinue)
        {
            //options[0] = "";
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
        Time.timeScale = 0;
        ourStory = new Story(inkJSON.text);
        storyPanel.SetActive(true);
        GameManager.instance.Phone.SetActive(false);
        currentOption = 0;
        AdvanceStory();
    }

    public void ExitStoryMode()
    {
        Time.timeScale = 1;
        storyDone = true;
        storyPanel.SetActive(false);
        GameManager.instance.Phone.SetActive(true);
    }

    void SetupOptions(string[] options)
    {
        foreach (string option in options)
        {
            for (int i = 0; i < 4; i++)
            {
                if (options[i] == null)
                {
                    optionUI[i].SetVisible(false);
                }
                else
                {
                    optionUI[i].SetVisible(true);
                    optionUI[i].SetOptionText(options[i]);
                    optionUI[i].SetSelected(i == currentOption);
                }
            }
        }
        
    }

    public void OnOptionClicked(int option)
    {
        rightText.text = "";
        leftText.text = "";
        midText.text = "";

        if (ourStory.canContinue)
        {
            AdvanceStory();
        }
        else
        {
            ourStory.ChooseChoiceIndex(option);
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

            if (tag.StartsWith("them"))
            {
                leftNameTag.SetActive(true);
                rightNameTag.SetActive(false);
                leftText.text = text;
                leftText.color = Color.red;
                didSomething = true;
            }

            if (tag.StartsWith("you"))
            {
                leftNameTag.SetActive(true);
                rightNameTag.SetActive(false);
                leftText.text = text;
                leftText.color = Color.red;
                didSomething = true;
            }

            if (tag.StartsWith("name;"))
            {
                string[] parts = tag.Split(';');
                string characterName = parts[1];
                //Instaead of having #them we can just use this to assign text to the right.
                rightNameTag.SetActive(true);
                leftNameTag.SetActive(false);
                rightText.text = text;
                rightText.color = Color.blue;
                rightNameTagText.text = characterName;
                didSomething = true;

                IconManager.instance.SetIcon(characterName);
                Debug.Log("icon should have changed to " + characterName);
                didSomething = true;
            }

            if (tag.StartsWith("stress;"))
            {
                print("accumulating stress");
                string[] parts = tag.Split(';');
                string emotionNumber = parts[1];
                int emotionValue;
                int.TryParse(emotionNumber, out emotionValue);
                GameManager.instance.currentEmotion = GameManager.instance.currentEmotion - emotionValue;
                didSomething = true;

                /*if (GameManager.instance.currentEmotion <= 0)
                {
                    ourStory = new Story(altInkJson.text);
                }*/
            }

            if (tag.StartsWith("end"))
            {
                ExitStoryMode();
                didSomething = true;
                storyDone = true;
                //lights.SetActive(true);
            }

            if (tag.StartsWith("narrator"))
            {
                rightNameTag.SetActive(false);
                leftNameTag.SetActive(false);
                midText.text = text;
                midText.color = Color.black;
                didSomething = true;
            }

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
            }*/

            
            if (!didSomething)
            {
                Debug.LogError("$Couldn't interpret tag");
            }
        }
    }
}