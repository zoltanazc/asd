using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Variable for the movement;
    public PlayerMovement movement;

    //Stops movement based on the tag of the object we hit.
    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    

}
