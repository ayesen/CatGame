using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public int newscore ;

    
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI state;

    public GameObject treat;
    public GameObject dryfood;
    public GameObject hit;

    // Start is called before the first frame update
    void Start()
    {
        newscore = groundTrigger.me.score;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Final Score: " + newscore.ToString();
        if(newscore == 0)
        {
            state.text = "Good Kitten! Here's your treat.";
            treat.SetActive(true);
        }

        if(newscore >0 && newscore < 2000)
        {
            state.text = "This is a mess. I'm not giving you good food today!";
            dryfood.SetActive(true);
        }

        if(newscore >= 2000 && newscore < 3000)
        {
            state.text = "What is happening here? You won't have dinner tonight.";
            
        }

        if(newscore >= 3000)
        {
            state.text = "Come here you evil cat!";
            hit.SetActive(true);
        }


    }
}
