using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catvoice : MonoBehaviour
{
    public AudioSource cataudio;
    public float randomPitch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cataudio.pitch = randomPitch;

        if (Input.GetMouseButton(0))
        {
            randomPitch = Random.Range(0.7f, 1.5f);
            cataudio.Play();

        }
    }
}
