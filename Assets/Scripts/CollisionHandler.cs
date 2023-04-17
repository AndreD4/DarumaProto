using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
      switch (other.gameObject.tag)
      {
        case "Friendly":
            Debug.Log ("this thing is friendly");
            break;

        case "Finish":
            LoadNextLevel();
            break;
        default:
            ReloadLevel();
            break;
      }
    }
    
    void LoadNextLevel()
    {
      int loadNextSceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(loadNextSceneIndex + 1);
    }

    void ReloadLevel()
    {
      int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(currentSceneIndex);
    }

}
