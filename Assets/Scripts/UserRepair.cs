using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class UserRepair : MonoBehaviour
{
    public int userRepairStat;
    public Story story;
    public float[] userbarValues = new float[30];

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        userRepairStat = story.Vars["userstat"];

    }
}
