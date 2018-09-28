using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // designer variables
    public float speed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // get axis input from unity
        float leftRight = Input.GetAxis(horizontalAxis);
        float upDown = Input.GetAxis(verticalAxis);

        // create direction vector for axis input
        Vector2 direction = new Vector2(leftRight, upDown);

        // make direction vector length 1
        direction = direction.normalized;

        // calculate velocity
        Vector2 velocity = direction * speed;

        // give the velocity to the rigid body
        physicsBody.velocity = velocity;

	}
}
