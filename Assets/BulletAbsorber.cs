using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class BulletAbsorber : MonoBehaviour

{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        print ("Wall has been collided with!!");
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("laserlaser") == true)
        {

            // turns off the playerGO
            // collision.gameObject.SetActive(false);

            // Elephant is gone
            // Destroy(collision.gameObject);



            Destroy(collision.gameObject);

        }
    }

}
