using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public GameObject BGMaudio;
    static public BGM thisBGM;

    // Start is called before the first frame update
    void Start()
    {
        thisBGM = this;
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
