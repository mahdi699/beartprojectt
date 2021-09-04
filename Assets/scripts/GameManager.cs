using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI ;

public class GameManager : MonoBehaviour
{  
   
   public  void mainmenu ()
  {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

  }
    public void mainmenulvl2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }
    public void mainmenulvl3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }
    public void mainmenulvl4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);

    }
    public void mainmenufinalboss()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);

    }

    public  void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
    public  void nextlvl ()
  {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

  }

  public  void reloadlvl ()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );


  }
 
    
}
