using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportToScene : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collider)
    {
         if (collider.name == "Mat_Round_Blue"){
            SceneManager.LoadScene("scene1");
         }
    }

}



