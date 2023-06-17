using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onOpenBook : MonoBehaviour
{
    public Animator animator = null;
    private bool canTurnPage = true;
    private int pageNum = 0;

    void OnTriggerEnter(Collider collider){
         if (collider.name == "BOOK_2" && canTurnPage){
            Debug.Log("turn page" + pageNum);  
            if (pageNum == 0){
                animator.SetBool("p01",true);
            }else if (pageNum == 1){
               //animator.SetBool("p01",false);
                animator.SetBool("p12",true);
            }else if (pageNum == 2){
                //animator.SetBool("p12",false);
                animator.SetBool("p34",true);
            }else if (pageNum == 3){
                //animator.SetBool("p34",false);
                animator.SetBool("p56",true);
            }else if (pageNum == 4){
                SceneManager.LoadScene("scene2");
            }
            canTurnPage = false;
         }
    }

    void OnTriggerExit(Collider other) {
        if (other.name == "BOOK_2"){
            pageNum ++;
            Debug.Log("add page" + pageNum);
            canTurnPage = true;
        }
    }
}



