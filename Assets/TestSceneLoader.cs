using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneLoader : MonoBehaviour
{
    // Method to load a test scene
    public void LoadTestScene()
    {
        // Load a scene by its build index or name
        SceneManager.LoadScene(1); // Change to the desired scene index or name
    }
}