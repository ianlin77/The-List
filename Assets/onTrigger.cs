using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTrigger : MonoBehaviour
{

    public Animator animator = null;
    private int pageNum = 0;

    void OnTriggerExit(Collider collider){
         if (collider.name == "BOOK_1" && pageNum == 0){
             pageNum =1;
         }
         if (collider.name == "BOOK_2" && pageNum >=1){
             if (pageNum == 1){
                 pageNum=2;
              }else if (pageNum == 2){
                 pageNum=3;
              }else if (pageNum == 3){
                 pageNum=4;
              }
              

         }
    }

    void OnTriggerEnter(Collider collider)
    {
         if (collider.name == "BOOK_1" && pageNum == 0){
             animator.SetBool("p01", true);
         }
         if (collider.name == "BOOK_2" && pageNum >=1){
             if (pageNum == 1){
                 animator.SetBool("p12", true);
              }else if (pageNum == 2){
                 animator.SetBool("p34", true);
              }else if (pageNum == 3){
                 animator.SetBool("p56", true);
              }
              

         }
    }

}



