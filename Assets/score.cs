using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public int newscore;
    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        newscore = groundTrigger.me.score;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Final Score: " + newscore.ToString();
    }
}
