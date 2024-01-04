using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GoalCheck : MonoBehaviour
{
    // This script should be on the GoalGO

    // An audio source variable that is only going to be used in this script
    private AudioSource audioSource;
    public float delayTime = 5f;

    private void Start()
    {
        // Store a reference to this gameobject's audio source component
        audioSource = GetComponent<AudioSource>();
    }

    // This happens when a trigger collision takes place (Is Trigger checked on one collider)
    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        // If the collider's gameobject's tag is Player...
        if (collision.gameObject.CompareTag("Player") == true)
         
        {

            print("Audio should be playing now we are in GoalCheck.OnTriggerEnter2D()");

            // Play the audio source component's audio clip once
            audioSource.PlayOneShot(audioSource.clip);
            Invoke("DelayedWin", delayTime);
        }
    }
    
    void DelayedWin()
    {
        SceneManager.LoadScene(3);

    }

}
