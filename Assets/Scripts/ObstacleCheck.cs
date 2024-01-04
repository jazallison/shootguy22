using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add the namespace to work with scenes
using UnityEngine.SceneManagement;

public class ObstacleCheck : MonoBehaviour
{
    public int HitsTaken = 0;

    

    // This happens when a collision takes place
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("We collided");
        print(collision.gameObject.tag);

        if (collision.gameObject.CompareTag("laserlaser") == true)

        {
            //obstacle disappears from game
            print("laserlaser");
            HitsTaken = HitsTaken + 1;
            if (HitsTaken > 40)
            {
                //GetComponent<Renderer>().enabled = false;

                


                Destroy(collision.otherCollider.gameObject);
                  
                    

            }


        }
        // If the collider's gameobject's tag is player...
        if (collision.gameObject.CompareTag("Player") == true)
        {
            // turns off the playerGO
            // collision.gameObject.SetActive(false);

            // Elephant is gone
            // Destroy(collision.gameObject);


            // Load the current active scene (restart scene)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        
    }
}