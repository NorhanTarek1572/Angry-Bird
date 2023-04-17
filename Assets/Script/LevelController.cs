using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;
using System;

public class LevelController : MonoBehaviour
{
    
    Monster[] monsters;
    public GameObject  gameOver , quit;
    public string nextLevelName;

    private void OnEnable()
    {
        // if there are enemt we will reset the level if no (all enemy is been killed we will go to the next level )
        monsters = FindObjectsOfType<Monster>();
    }
    
    void Update()
    {
        
        if (MonstersAreDead() && LivesCounter.health>=0) GoNextLevel();
        else if   (!MonstersAreDead()  && LivesCounter.health<0 ) {
            GameOver();         
        }
        /*
        if (LivesCounter.health>0 && MonstersAreDead() ) GoNextLevel();

        else if(LivesCounter.health==0 ){
            if(MonstersAreDead()) GoNextLevel();
            else GameOver();
        }
        */
   
    }

    bool MonstersAreDead() {  
        // make sure the there is no ememy is alive 
        foreach (var  monster in monsters) { 
            if (monster.gameObject.activeSelf) return false ;
            }
        return true;
    }

    void GoNextLevel() { 
        SceneManager.LoadScene(nextLevelName);
    }
   
    void GameOver(){
            gameOver.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);          
            Time.timeScale = 0 ; 
    }


   
}
