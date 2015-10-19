using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public Vector2 speed = new Vector2(5, 5);
	public Vector2 normalSpeed = new Vector2(5, 5);
	public Vector2 fastSpeed = new Vector2(5, 5);
	private Vector2 movement;
	Vector3 posSlime;
	private bool isMoving;
	Animator anim;
	public int health;
	public GameObject blob1;
	public GameObject blob2;
	Vector2 non = new Vector2(0, 0);

	void Start()
	{
		anim = GetComponent<Animator> ();
		isMoving = false;
	}

	void Update()
	{
		posSlime = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 1);

		if (isMoving == true) 
		{
			blob1 = (GameObject)Instantiate(blob1, posSlime, transform.rotation);
		}
		fastSpeed = speed * 2;
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		movement = new Vector2(speed.x * inputX, speed.y * inputY);
		if (movement != non) 
		{
			isMoving = true;
		} 
		else 
		{
			isMoving = false;
		}

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