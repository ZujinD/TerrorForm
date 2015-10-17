using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour 
{
	
	public Transform target;//set target from inspector instead of looking in Update
	Quaternion enemyRotation;
	Vector2 playerPos, enemyPos;
	public Vector3 projectilePos;
	public GameObject spit;
	int spitLayer;
	public float fireDelay = 1.0f;
	public AudioClip spitSound;
	float cooldownTimer = 0;
	float moveTimer = 0;
	public float moveDelay = 0.5f;
	public Transform origin;
	public float rotSpeed = 900f;

	void Start()
	{
		enemyRotation = this.transform.localRotation;
		spitLayer = gameObject.layer;
		origin = transform.FindChild ("spitPos");
	}

	void Update()
	{
		Vector3 dir = target.position - origin.position;
		float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
		origin.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);

		if(target == null) 
		{
			GameObject playerOb = GameObject.FindWithTag ("Player");
			if(playerOb != null) 
			{
				target = playerOb.transform;
			}
		}

		playerPos = new Vector2(target.localPosition.x,target.localPosition.y);//player position 
		enemyPos = new Vector2 (this.transform.localPosition.x, this.transform.localPosition.y);//enemy position
		if (Vector3.Distance (transform.position, target.transform.position) > 1.6 && Vector3.Distance (transform.position, target.transform.position) < 5)//move towards if not close by 
		{
			transform.position = Vector2.MoveTowards (enemyPos, playerPos, 2 * Time.deltaTime);
		}
		if (moveTimer == 0 && Vector3.Distance (transform.position, target.transform.position) < 1.55)//move away if too close 
		{
			transform.position = Vector2.MoveTowards (enemyPos, playerPos, -1 * Time.deltaTime);
		}

		if (target.position.x > this.transform.position.x)//rotates enemy to the right if player is to the right  
		{
			enemyRotation.y = 180;
			transform.localRotation = enemyRotation;
		}
		if (target.position.x < this.transform.position.x)//rotates enemy to the left if player is to the left 
		{
			enemyRotation.y = 0;
			this.transform.localRotation = enemyRotation;
		}

		if (cooldownTimer <= 0 && target != null && Vector3.Distance (transform.position, target.position) < 3)
		{
			Attack();
		}
		moveTimer -= Time.deltaTime;
		cooldownTimer -= Time.deltaTime;
	}

	void Attack()
	{
		moveTimer = moveDelay;
		cooldownTimer = fireDelay;
		AudioSource.PlayClipAtPoint(spitSound, gameObject.transform.localPosition);
		GameObject spitGO = (GameObject)Instantiate(spit, origin.transform.position, origin.rotation);
		spitGO.layer = spitLayer;
	}
	
}