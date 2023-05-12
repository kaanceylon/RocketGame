using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppQuit : MonoBehaviour
{
   
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("We Pushed Escape!");
            Application.Quit();
        }
    }
}
