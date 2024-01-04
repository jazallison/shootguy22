using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgaudio : MonoBehaviour

{
    /*private AudioSource audioSource;
    private void Start()
    {
        // Store a reference to this gameobject's audio source component
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioSource.clip);

    }

    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
       
    }*/

    private static bgaudio instance = null;
    public static bgaudio Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // any other methods you need
}


