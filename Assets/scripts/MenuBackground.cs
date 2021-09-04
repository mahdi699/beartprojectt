using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuBackground : MonoBehaviour
{


    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quitgame()
    {
        Debug.Log("quitt!!");
        Application.Quit();
    }
    public void optionsgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    public void optionnnnngame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
 
}
