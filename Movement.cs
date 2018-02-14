using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float PlayerMove;
    private Rigidbody2D MyRigidbody2d;

    private bool playerMovement;
    private Vector2 lastMove;

	// Use this for initialization
	void Start () {
        MyRigidbody2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        playerMovement = false;

        if (Input.GetAxisRaw("Horizontal") > 0.1f || Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            MyRigidbody2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * PlayerMove, MyRigidbody2d.velocity.y);
            playerMovement = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0.1f || Input.GetAxisRaw("Vertical") < -0.1f)
        {
            MyRigidbody2d.velocity = new Vector2( MyRigidbody2d.velocity.x, Input.GetAxisRaw("Vertical") * PlayerMove);
            playerMovement = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        if(Input.GetAxisRaw("Horizontal") < 0.1f && Input.GetAxisRaw("Horizontal") > -0.1f)
        {
            MyRigidbody2d.velocity = new Vector2(0f, MyRigidbody2d.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") < 0.1f && Input.GetAxisRaw("Vertical") > -0.1f)
        {
            MyRigidbody2d.velocity = new Vector2(MyRigidbody2d.velocity.x, 0f);
        }
        }
}
