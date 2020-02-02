using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using System.Linq;
using System;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour
{
    public Story story;
    public TextMeshPro ScreenText;

    // Start is called before the first frame update
    string currStoryText = "";
    List<string> currStoryLink = new List<string>();
    void Start()
    {
        //buttons[0].click .onClick.AddListener(OnClickButton);
        story.OnOutput += Story_OnOutput;
        story.OnPassageExit += Story_OnPassageExit;
    }

    private void Story_OnPassageExit(StoryPassage obj)
    {
        currStoryText = "";
        currStoryLink = new List<string>();
    }

    private void Story_OnOutput(StoryOutput obj)
    {
        string tType = obj.GetType().ToString();

        if (tType == "Cradle.StoryText" || tType == "Cradle.StoryLink" || tType == "Cradle.LineBreak")
        {
            if (tType == "Cradle.LineBreak")
                currStoryText += "\n";
            else
                currStoryText += obj.Text;
        }
        //switch (tType)
        //{
        //    case "Cradle.StoryText":
        //        currStoryText += obj.Text;
        //        break;
        //    case "Cradle.StoryLink":
        //        currStoryLink.Add(obj.Text);
        //        break;
        //}

        ScreenText.SetText(currStoryText);
    }    
}
