using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // to count the score of your level 
    public Text myScoreText; // the word score in the unity 
    public static int scoreNum = 0 ;

    void Start()
    {
        myScoreText.text = "Score : " + scoreNum.ToString() ;
    }
    
    private void OnTriggerEnter2D(Collider2D score  )
    {
        if (score.tag ==" Monster")
        {
            scoreNum++; 
            myScoreText.text = "Score : " + scoreNum.ToString() ;
           // Destroy(score.gameObject); 
            score.gameObject.SetActive(false);
        }
       
    }
  

}
