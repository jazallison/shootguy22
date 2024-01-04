using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class laserdestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        print("bullets r touching?!");
       //if (collision..CompareTag("laserlaser") == true)
        {
            Collider2D collider1 = collision.collider;
            Collider2D collider2 = collision.otherCollider;

            string collider1Name = collider1.gameObject.name;
            string collider2Name = collider2.gameObject.name;



            Debug.Log("Colliders impacted: " + collider1Name + " and " + collider2Name);
            // turns off the playerGO
            // collision.gameObject.SetActive(false);
            if (collider1.gameObject.tag == "laserlaser" && collider2.gameObject.tag == "laserlaser")
            {
                Destroy(collision.gameObject);
            }
            // Elephant is gone
       



            // Destroy(collision.gameObject);

        }
    }

}