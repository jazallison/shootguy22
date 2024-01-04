using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // I want a bool that is in the class Timer.
    // The Timer class is attached to the TimerGO
    // The instance of the Timer class that I want is on the TimerGO
    // TO get a reference I need a variable of type GameObject
    public GameObject TimerGO;

    // Now I need a variable of type Timer
    private Timer myTimer;

    // Which Prefab do we want to instantiate?
    public GameObject SpawnedGO;

    // Where should we put that
    public Transform AssignedParent;

    public int MaximumHexogons;
    private int actualNumberOfHexogons;

    // Start is called before the first frame update
    void Start()
{
    // Instantiate a Prefab, and give it the same transform as the game object I called AssignedParent
    Instantiate(SpawnedGO, AssignedParent);

    // This is where myTimer gets its value, meaning I tell myTimer which instance I want it to look at.  I want the Timer tht is in the TimerGO
    myTimer = TimerGO.GetComponent<Timer>();

}

// Update is called once per frame
void Update()
{
    if (Input.GetKey("space")) // (Input.GetKeyDown("space"))
    {
        print ("Spacebar is working!!");

        // Only make hexogons if time is not up yet
        if(myTimer.TimeIsUp == false)
        {
            RainDownHexagons();
        }
    }
}

    // You can call this method from any block of code, like When a button is pressed
    // Or when a collision happens, or any condition is met....
    public void RainDownHexagons()
    {
        // This block of code only accessed when actualNumberOfHexogons is less than MaximumHexogons
        if (actualNumberOfHexogons < MaximumHexogons)
        {
            // Instantiate SpawnedGIO and give it the same transform as the GameObject AssignedParent
            Instantiate(SpawnedGO, AssignedParent);

            actualNumberOfHexogons++;  // add 1 everytime we instantiate a Hexogon

            // print("Now we have this many Hexidudes: " + MaximumHexogons+ " and time is "+ Time.time);
        }
    }
}