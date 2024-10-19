using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class Restart : MonoBehaviour
    {
    [MenuItem("Helpers/Restart Scene #E")]
        private static void RestartScene()
        {
        var currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
        }
    }

