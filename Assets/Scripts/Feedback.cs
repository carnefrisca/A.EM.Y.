using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class Feedback : MonoBehaviour
{
    public Story story;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void PositiveFeedback ()
    {
        story.Vars["aitraining"] += 1;
        Debug.Log("story.Vars.aitraining = " + story.Vars["aitraining"].ToString());
    }

   public void NegativeFeedback()
    {
        story.Vars["aitraining"] += 1;
        Debug.Log("story.Vars.aitraining = " + story.Vars["aitraining"].ToString());
    }

}
