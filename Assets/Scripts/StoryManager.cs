using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using TMPro;

public class StoryManager : MonoBehaviour
{
    public TextAsset storyJson;
    public TextMeshProUGUI leftText, rightText;
    public Button[] optionButtons;
    public TextMeshProUGUI[] optionButtonLabels;
    public Animator leftAnimator, rightAnimator;

    Story ourStory;

    // Start is called before the first frame update
    void Start()
    {
        ourStory = new Story(storyJson.text);
        AdvanceStory();
    }

    // Update is called once per frame
    void Update()
    {
        string[] options = new string[3];

        if (ourStory.canContinue)
        {
            options[0] = "...";
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

    void SetupOptions(string[] options)
    {
        for (int i = 0; i < 3; i++)
        {
            if (options[i] == null)
            {
                optionButtons[i].gameObject.SetActive(false);
            }
            else
            {
                optionButtons[i].gameObject.SetActive(true);
                optionButtonLabels[i].text = options[i];
            }
        }
    }

    public void OnOptionClicked(int index)
    {
        leftText.text = "";
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
    }

    void AdvanceStory()
    {
        string text = ourStory.Continue();
        Animator currentAnimator = null;

        if (ourStory.currentTags.Contains("you"))
        {
            leftText.text += text;
            currentAnimator = leftAnimator;
        }

        if (ourStory.currentTags.Contains("them"))
        {
            rightText.text += text;
            currentAnimator = rightAnimator;
        }

        /*foreach (string tag in ourStory.currentTags)
        {
            if (tag.StartsWith("sound;"))
            {
                // "sound;music_octo"
                string[] parts = tag.Split(';');
                // ["sound", "music_octo"]
                string soundName = parts[1];
                // "music_octo"
                Debug.Log("The name is " + soundName);
                SoundManager.instance.PlaySound(soundName);

            }

            if (tag.StartsWith("anim;"))
            {
                string[] parts = tag.Split(';');
                string animName = parts[1];

                if (currentAnimator != null)
                {
                    currentAnimator.SetTrigger(animName);
                }
                else
                {
                    Debug.LogError("Anim tag foudn but not set to character");
                }

            }

            if (tag.StartsWith("effect;"))
            {
                string[] parts = tag.Split(';');
                string effectName = parts[1];

                EffectsManager.instance.PlayEffect(effectName);

                //Debug.Log("Particle is Playing.");
            }

        }*/
    }
}