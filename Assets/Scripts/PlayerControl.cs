using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Attached to PlayerGO
    // This script will control the player's movement


    // Variables which can be modified in the Inspector
    public float speed = 7;
    public bool slide;
    public float drag = 2f;

    public GameObject thingCollidedwWith;

    // Variables used only within this script
    private Vector2 direction;
    private Rigidbody2D rb2d;
    private Rigidbody2D gun_rb2d;
    private SpriteRenderer bluboSR;
    public Sprite bluboSprite;
    public bool player2;

    private void Start()
    {
        // Set this gameobject's tag to Player. You can also do this in the Inspector
        gameObject.tag = "Player";

        // Store a reference to the rigidbody2d component to use in this script
        rb2d = gameObject.GetComponent<Rigidbody2D>();

        GameObject otherObject = GameObject.Find("laser");
        gun_rb2d = otherObject.GetComponent<Rigidbody2D>();


        //use sprite renderer to change sprite into blubo. declare sprite renderer
        //give it a value so it knows which sprite renderer we're talkin about B)
        bluboSR = gameObject.GetComponent<SpriteRenderer>();
        //change player sprite to blubo.
        bluboSR.sprite = bluboSprite;

        // 

    }

    // Update is called once per frame
    private void Update()
    {
        // Store the values of the input axes in a Vector2 to use later
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        direction = new Vector2(Input.GetAxisRaw("horizontal player 2"), Input.GetAxisRaw("vertical player 2"));
        
        
    }

    // FixedUpdate is for physics
    private void FixedUpdate()
    {
        // If the slide bool is set to true
        if (slide == true)
        {
            // Set the rigidbody2d drag property to the value of drag
            rb2d.drag = drag;
        }
        else
        {
            // If the slide bool is set to false...
            // Set the rigidbody2d drag property to 0
            rb2d.drag = 0;
            rb2d.mass = 5;
            // Set the rigidbody2d velocity property to 0,0 (this stops movement)
            rb2d.velocity = new Vector2(0.0f,0.0f);
            
        }

        // Add an instant forces to the rigidbody2d. The forces are the input values * the speed value
        //this is what makes it move
        rb2d.AddForce(direction * speed, ForceMode2D.Impulse);


        // Get the current position of the other object
        Vector2 gunPos = rb2d.position;

        // Create a new posi tion with the desired y-axis offset
        float yOffset = -1f; // Replace this with your desired offset
        Vector2 newPosition = new Vector2(gunPos.x, gunPos.y + yOffset);

        // Move the rigidbody2d to the new position
        gun_rb2d.MovePosition(newPosition);



    }

}