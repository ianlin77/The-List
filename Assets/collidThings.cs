using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidThings : MonoBehaviour
{
    public GameObject actorObj = null;

    void OnCollisionEnter(Collision other) {
        if (other.collider.name == "Fireplace_Door"){
            //Debug.Log("hit");
            actorObj.SetActive(true);
        }
        
    }
}
