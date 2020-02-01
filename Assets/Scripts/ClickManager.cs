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
        button.onClick.AddListener(ClickLink);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickLink()
    {
        story.DoLink(ButtonIndex);
    }
}
