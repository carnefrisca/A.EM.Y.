using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using UnityEngine.UI;

public class UserRepair : MonoBehaviour
{
    public int userRepairStat;
    public Story story;
    public float[] userbarValues = new float[30];
    public Image bar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        userRepairStat = story.Vars["userstat"];
        bar.fillAmount = userbarValues[userRepairStat];
    }
}
