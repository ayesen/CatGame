using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class groundTrigger : MonoBehaviour
{
    public int score = 0;
    public float timer = 120;

    public TextMeshProUGUI scoretxt;
    public TextMeshProUGUI timertxt;

    static public groundTrigger me;

    public AudioSource falling;
    public List<AudioClip> audios = new List<AudioClip>();

    // Start is called before the first frame update
    void Start()
    {
        me = this;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        scoretxt.text = "Your Score: "+ score.ToString();
        timertxt.text = "Time Left: " + (Mathf.RoundToInt(timer)).ToString();
        
        if(timer <= 0)
        {
            SceneManager.LoadScene("end");
        }

        

        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("objectsonground");
        score += 100;

        falling.clip = audios[Random.Range(0, 3)];
        falling.Play();

    }
}
