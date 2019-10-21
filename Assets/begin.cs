using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class begin : MonoBehaviour
{
    public AudioSource cataudio;
    public List <AudioClip> audioClips = new List<AudioClip>();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButton(0))
        {
            cataudio.clip = audioClips[Random.Range(0, 3)];
            cataudio.PlayOneShot(cataudio.clip);
            SceneManager.LoadScene("play");
            
        }
    }
}
