using UnityEngine;
using System.Collections;

public class BaseStats : MonoBehaviour 
{
	public int Health;
	public AudioClip attackHit;
	private AudioSource source;
	public float HealthBar;
	public float HealthBarSegment;
	GameObject bar;
	Vector3 temp;
	Quaternion barRotation;
	public GameObject DNA;
 
	void Start () 
	{
		source = GetComponent<AudioSource>();
		bar = gameObject.transform.FindChild ("hpbar").gameObject;
		temp = bar.transform.localScale;
		HealthBar = temp.x;
		HealthBarSegment = temp.x / Health;
	}


	void Update()
	{
		barRotation = transform.localRotation;
		barRotation.x = 0;
		transform.localRotation = barRotation;
		temp.x = HealthBar;
		bar.transform.localScale = temp;
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "AttackTentacle" && Health > 0) 
		{
			source.PlayOneShot(attackHit);
			Health -= 1;
			HealthBar = HealthBar - HealthBarSegment;
			if(gameObject.name != "Player")
			{
				if(Health == 0)
				{
					AudioSource.PlayClipAtPoint(attackHit, gameObject.transform.localPosition);
					Instantiate(DNA, transform.position, transform.rotation);
					Destroy(gameObject);
				}
			}
		}

	}
}

