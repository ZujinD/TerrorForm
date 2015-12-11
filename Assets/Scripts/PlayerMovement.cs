using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public static Vector2 speed = new Vector2(5, 5);
	public static Vector2 normalSpeed = new Vector2(5, 5);
	public static Vector2 fastSpeed = new Vector2(5, 5);
	private Vector2 movement;
	Vector3 posSlime;
	private bool isMoving;
	Animator anim;
	public float health;
	public float healthMax;
	public float curMaxHealth;
	public GameObject blob1;
	public GameObject blob2;
	public static float speedMult;

	void Start()
	{
		anim = GetComponent<Animator> ();
		isMoving = false;
		speedMult = 1f;
		curMaxHealth = healthMax;
	}

	void Update()
	{
		posSlime = new Vector3 (transform.position.x, transform.position.y, transform.position.z + 1);
		if (isMoving == true) 
		{
			Instantiate(blob1, posSlime, transform.rotation);
		}

		fastSpeed = normalSpeed * 1.5f;
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		movement = new Vector2(normalSpeed.x * inputX, normalSpeed.y * inputY);

		if (GetComponent<Rigidbody2D>().velocity != Vector2.zero) 
		{
			isMoving = true;
		} 
		else 
		{
			isMoving = false;
		}

		if(Input.GetKeyDown(KeyCode.LeftShift))
		{
			normalSpeed = fastSpeed;
		}
		if(Input.GetKeyUp(KeyCode.LeftShift))
		{
			normalSpeed = speed * speedMult;
		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			anim.SetTrigger("Attack");
		}


	}

	public static void incSpeed()
	{
		speedMult = speedMult + 0.1f;
		normalSpeed = speed * speedMult;
	}

	public void incHealth()
	{
		healthMax = curMaxHealth + ((float)GameAll.getEnd () * 2);
	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}