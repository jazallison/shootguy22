using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene("Completed Example");
    }

    public void OnControlReturn()
    {

        SceneManager.LoadScene("controls insturctions");
    }

   
}
