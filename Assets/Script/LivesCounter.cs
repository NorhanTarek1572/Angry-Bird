using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// this class only for counting the lives (we dont care about next level or gameover )
public class LivesCounter : MonoBehaviour
{
     public GameObject heart1 , heart2 , heart3 , heart4, gameOver ;
    //public GameObject  gameOver , quit;
    public static int health ; 
    //public string levelName ;
    void Start()
    {
        health = 4 ;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    
    void Update()
    {
       if(health>4) health =4;

       switch(health){
        case 3 :
            heart4.gameObject.SetActive(false);
            break ;
        case 2 :
          
            heart3.gameObject.SetActive(false);
            heart4.gameObject.SetActive(false);
            break ;
        case 1 :
           
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            heart4.gameObject.SetActive(false);
            break ;
        case 0 :
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
            heart4.gameObject.SetActive(false);
            break ;


       }

    }
   
   
}
