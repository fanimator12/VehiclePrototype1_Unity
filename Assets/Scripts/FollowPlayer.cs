using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetBack = new Vector3(0, 10, -15);
    private Vector3 offsetFront = new Vector3(57.65f, -19.5f, -93.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            // Offset the camera to the place of the player by adding to the player's position
            transform.position = player.transform.position + offsetFront;
        } else
        {
            // Offset the camera behind the player by adding to the player's position
            transform.position = player.transform.position + offsetBack;
        }
    }
}
