using UnityEngine;
using System.Collections;

public class BaseStats : MonoBehaviour 
{
	public float maxHealth;
	public float currentHealth;
	public AudioClip attackHit;
	private AudioSource source;
	public float HealthBar;
	GameObject bar;
	Vector3 temp;
	Quaternion barRotation;
	public GameObject DNA;
	float scale;
 
	void Start () 
	{
		source = GetComponent<AudioSource>();
		bar = gameObject.transform.FindChild ("hpbar").gameObject;
		temp = bar.transform.localScale;
		HealthBar = temp.x;
		currentHealth = maxHealth;
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
		if (col.gameObject.name == "AttackTentacle" && currentHealth > 0) 
		{
			source.PlayOneShot(attackHit, GameAll.sfxVolume);
			currentHealth -= 1 + (float)GameAll.getKin() * 0.5f;
			scale = currentHealth / maxHealth;
			HealthBar = HealthBar * scale;
			if(gameObject.name != "Player")
			{
				if(currentHealth <= 0)
				{
					AudioSource.PlayClipAtPoint(attackHit, gameObject.transform.localPosition, GameAll.sfxVolume);
					Instantiate(DNA, transform.position, transform.rotation);
					Destroy(gameObject);
				}
			}
		}

	}
}

