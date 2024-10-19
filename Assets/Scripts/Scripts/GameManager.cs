using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void CompleteLevel() 
    {
        completeLevelUI.SetActive(true);
    }

    public GameObject completeLevelUI;

    public void EndGame () 
    {

        Debug.Log("GAME OVER");
    
    }

}
