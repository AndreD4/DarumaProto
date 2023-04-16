using UnityEngine;

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
            Debug.Log ("yay you did it");
            break;
        default:
            Debug.Log ("you died");
            break;
      }
    }
    
}
