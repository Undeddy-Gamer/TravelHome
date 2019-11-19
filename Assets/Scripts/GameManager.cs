using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Function to change to 'next scene'
    public void NextScene()
    {
        //Get active scene
        Scene activeScene = SceneManager.GetActiveScene();
        //Change to active scene index +1
        SceneManager.LoadScene(activeScene.buildIndex + 1);

    }

}
