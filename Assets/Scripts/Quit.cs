using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Cradle;

public class Quit : MonoBehaviour
{
    public GameObject aemyText;
    public GameObject quitText;
    public GameObject myButtonY;
    public GameObject myButtonN;
    public Story story;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            aemyText.SetActive(false);
            quitText.SetActive(true);
            myButtonN.GetComponent<Image>().color = Color.white;
            myButtonY.GetComponent<Image>().color = Color.white;
        }
        if (Input.GetKeyDown("y"))
            {
            QuitGame();
        }
        if (Input.GetKeyDown("n"))
        {
            KeepPlaying();
        }
        if (Input.GetKeyDown("0"))
        {
            story.DoLink(0);
        }
        if (Input.GetKeyDown("1"))
        {
            story.DoLink(1);
        }

    }


    public void QuitGame()
    {
        if (quitText.activeInHierarchy == true)
        {
            Application.Quit();
        }
    }

    public void KeepPlaying()
    {
        if (quitText.activeInHierarchy == true)
        {
            aemyText.SetActive(true);
            quitText.SetActive(false);
            myButtonN.GetComponent<Image>().color = Color.grey;
            myButtonY.GetComponent<Image>().color = Color.grey;
        }
    }
}
