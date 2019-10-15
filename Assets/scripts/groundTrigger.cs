using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class groundTrigger : MonoBehaviour
{
    public int score = 0;
    public Text scoretxt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = "Your Score: "+score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("objectsonground");
        score += 100;
    }
}
