using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class ClickManager : MonoBehaviour
{
    public Story story;
    UnityEngine.UI.Button button;
    public int ButtonIndex;


    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<UnityEngine.UI.Button>();
        try
        {
            button.onClick.AddListener(ClickLink);
        }
        catch { }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClickLink()
    {
       
        story.DoLink(ButtonIndex);
        
    }
}
