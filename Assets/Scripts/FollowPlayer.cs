using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Create a variable for the players transformation.
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
