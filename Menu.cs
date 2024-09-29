using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void EnterGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
    }



}
