using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{ 
    [SerializeField] float  crashDelay = 1f;
    [SerializeField] float waitForNextLevel = 1f;
    [SerializeField] AudioClip finish;
    [SerializeField] AudioClip crash;
    AudioSource audioSource;
    
    void Start()
    {
      audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
      switch (other.gameObject.tag)
      {
        case "Friendly":
            Debug.Log ("this thing is friendly");
            break;

        case "Finish":
            StartFinishSequence();
            break;
        default:
            StartCrashSequence();
            break;
      }
    }

     void StartFinishSequence()
    {
      audioSource.PlayOneShot(finish);
      GetComponent<Movement>().enabled = false;
      Invoke("LoadNextLevel", waitForNextLevel);
    }
    
    void StartCrashSequence()
    {
      audioSource.PlayOneShot(crash);
      GetComponent<Movement>().enabled = false;
      Invoke("ReloadLevel", crashDelay);
    }
    
    void LoadNextLevel()
    {
      int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      int nextSceneIndex = currentSceneIndex + 1;
      if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
      {
        nextSceneIndex = 0;
      }

      SceneManager.LoadScene(nextSceneIndex);

    }

    void ReloadLevel()
    {
      int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(currentSceneIndex);
    }

}
