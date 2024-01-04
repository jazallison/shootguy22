using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30;
    public GameObject laserlaser;
    public float laserlaserSpeed = 40;
    private Vector2 direction;
    public float godspeed = 10;
    public bool slide;
    public float drag = 2f;
    private Rigidbody2D rb2d;
    float vAxis;
    float hAxis;


    private void Start()
    {
        vAxis = Input.GetAxis("Vertical");
        hAxis = Input.GetAxis("Horizontal");
        rb2d = gameObject.GetComponent<Rigidbody2D>();


    }

    void Update()
    {
        

        transform.rotation = Quaternion.Euler(vAxis * pitchMult, hAxis * rollMult, 0);

        if (Input.GetKeyDown("space"))
        {
            TempFire();
        }
        
            // Store the values of the input axes in a Vector2 to use later


    
        }

        void TempFire()
    {
        GameObject projGO = Instantiate<GameObject>(laserlaser);
        projGO.transform.position = transform.position;
        Rigidbody2D rigidB = projGO.GetComponent<Rigidbody2D>();
        Vector3 vector3 = Vector3.right * laserlaserSpeed;
        rigidB.velocity = vector3;

    }


}


    
     