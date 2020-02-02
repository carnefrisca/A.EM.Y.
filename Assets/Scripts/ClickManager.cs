using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class ClickManager : MonoBehaviour
{
    public Story story;
    UnityEngine.UI.Button button;
    public int ButtonIndex;
    public float[] userbarValues = new float[30];

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

    void ClickLink()
    {
       
        story.DoLink(ButtonIndex);
        
    }
}
