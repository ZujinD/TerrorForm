using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	public float Speed = 2.5f;
	public float timer = 2f;
	GameObject hpbar;
	HealthBar healthbar;

	void Start()
	{
		hpbar = GameObject.Find ("HealthBar");
		healthbar = hpbar.GetComponent<HealthBar> ();
	}

	void Update () 
	{
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3(0, Speed * Time.deltaTime, 0);
		pos += transform.rotation * velocity;
		transform.position = pos;

		timer -= Time.deltaTime;
		if(timer <= 0) 
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" ) 
		{
			healthbar.HealthDown(1);
			Destroy(gameObject);
		}
	}
}
