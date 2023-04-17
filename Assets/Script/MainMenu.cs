using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   
  public void GoToScene(string scaneName) {
        SceneManager.LoadScene(scaneName);  
        ResetGame();
         
    }
    public void Quit()
    {
            Application.Quit();
            Debug.Log("Application has quit : ..");
    }
    
  public void ResetGame(){
        Score.scoreNum =0 ;
        LivesCounter.health=4;   
        Time.timeScale =1;
  }


}
