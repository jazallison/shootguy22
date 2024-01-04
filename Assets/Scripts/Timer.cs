using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Timer : MonoBehaviour
{
    // I want a reference to my characterGO So this is the first part of 
    // getting a reference: Declare a variable of type GameObject.  (*Type see devlog)
    // I named it CharacterGO, but that doesn't mean it IS my character: 
    // I could have named it Tofu.  
    // The compiler only knows which instance I want because I will drag an 
    // instance of the GameObject variable type into the box in the Unity Editor.
    public GameObject CharacterGO;

    // Same as above, I know I want a reference to a SpriteRenderer, 
    // so I need to declare a variable 
    private SpriteRenderer charactersSpriteRenderer;

    // public Text TimeLeftText;
    public TMP_Text TimeRemainingTextField;
    public int RemainingSeconds = 30;
    public bool TimeIsUp;
    public GameObject GameOverPanel;
    // public GameObject StartScreen;

    // Start is called before the first frame update
    void Start()
    {
        // We call the Coroutine once in Start() 
        StartCoroutine(CountdownTimer());           // The method was called "WaitAndPrint" in class. I renamed it.
        
        // Assigning the correct instance of SpriteRenderer
        charactersSpriteRenderer = CharacterGO.GetComponent<SpriteRenderer>();
    }



    // This is our Coroutine!  Our first one!  It also contains our first loop!
    // Ienumerators are a special kind of C# method
    // Ienumerators are the only methods (that we use in Unity) that can YIELD control and ask the compiler to come back later
    IEnumerator CountdownTimer()
    {
        while (RemainingSeconds > 0)
            {
                // timer needs to wait 1 second
                yield return new WaitForSeconds(1);

                // Decrement our timer
                RemainingSeconds = RemainingSeconds - 1;

                // Print because it is the best way to check for errors!!
                print("Seconds Left " + RemainingSeconds);

                // This is nicer than just printing to the console, but it is easy to mess up
                // We provide the correct instance of the TMP Textfield. (I remained it)
                // 
                // Then we take the integer "TimerTimeLeftSecond" and cast it to a string...
                TimeRemainingTextField.text = RemainingSeconds.ToString();

            } // This is the end of the loop  
            // (I often make a comment here  Below this ppoint are thing sthat only happen after the loop is finished) 

            print("Time is up" + Time.time);

            // Game Over Panel 
            GameOverPanel.SetActive(true);

            //  Make char turn GREEN when time up
            charactersSpriteRenderer.color = Color.green;

            //Make a bool become true: You can use this to create a block of code that is only reached when time is up 
            TimeIsUp = true;
        }
   }