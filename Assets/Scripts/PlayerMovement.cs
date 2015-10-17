using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public Vector2 speed = new Vector2(5, 5);
	public Vector2 normalSpeed = new Vector2(5, 5);
	public Vector2 fastSpeed = new Vector2(5, 5);
	private Vector2 movement;
	private bool isMoving;
	Animator anim;
	public int health;

	void Start()
	{
		anim = GetComponent<Animator> ();
		isMoving = false;
	}

	void Update()
	{
		if (isMoving == false) 
		{

		}
		fastSpeed = speed * 2;
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		movement = new Vector2(speed.x * inputX, speed.y * inputY);
		if(Input.GetKeyDown(KeyCode.LeftShift))
		{
			speed = fastSpeed;
		}
		if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			speed = normalSpeed;
		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			anim.SetTrigger("Attack");
		}
	}
	
	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}