using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ball_controller : MonoBehaviour
{
    public Vector3 pos;
    public Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);

    public CircleCollider2D collider;
    private BoxCollider2D[] borderColliders;



    // Start is called before the first frame update
    void Start()
    {
        // Get the current position of the ball
        pos = transform.position;
        // Get the collider of the ball wich is a circle collider 2D
        collider = GetComponent<CircleCollider2D>();

        
        //Get the collides of the borders
        GameObject borders = GameObject.Find("Borders");
        // In this case, the borders are the children of the game object
        // So we can get the colliders by using GetComponentsInChildren
        borderColliders = borders.GetComponentsInChildren<BoxCollider2D>();
        // Print the number of colliders
        
     
    }

    // Update is called once per frame
    void Update()
    {

        // Check if the ball collides with the borders
        foreach (BoxCollider2D borderCollider in borderColliders)
        {

            if (collider.IsTouching(borderCollider))
            {
                // If the ball collides with the borders, the ball will bounce
                // So we need to change the direction of the ball
                // We can do this by changing the velocity of the ball
                // If the ball collides with the top or bottom border, we need to change the y velocity
                // If the ball collides with the left or right border, we need to change the x velocity
                // We can check the name of the border collider to know which border the ball collides with
                // If the name of the border collider is "Top", the ball collides with the top border
                // If the name of the border collider is "Bottom", the ball collides with the bottom border
                // If the name of the border collider is "Left", the ball collides with the left border
                // If the name of the border collider is "Right", the ball collides with the right border
                // We can use the function GetComponent to get the component of the border collider
                // In this case, we need to get the component of the transform
                borderCollider.GetComponent<Transform>();
                if (borderCollider.name == "Top" || borderCollider.name == "Bottom")
                {
                    // If the ball collides with the top or bottom border, we need to change the y velocity
                    velocity.y = -velocity.y;
                }
                else if (borderCollider.name == "Left" || borderCollider.name == "Right")
                {
                    // If the ball collides with the left or right border, we need to change the x velocity
                    velocity.x = -velocity.x;
                }


                // We can break the loop because we don't need to check the other borders
                break;


            }
        }

        // finally, we need to update the position of the ball
        // We can do this by adding the velocity to the position
        pos += velocity;
        // We can update the position of the ball by using the function transform.position
        transform.position = pos;

    }
}
