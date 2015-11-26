using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour 
{
	Vector3 scale;
	GameObject playerA;
	public AudioClip hit;
	public float curHealth;
	public float maxHealth;
	float barScale;
	public float hpBar;

	void Start () 
	{
		playerA = GameObject.Find ("Player");
		maxHealth = playerA.GetComponent<PlayerMovement>().healthMax;
		curHealth = maxHealth;
		scale = transform.localScale;
		hpBar = scale.x;
	}
	void Update ()
	{
		scale.x = hpBar;
		transform.localScale = scale;
		maxHealth = playerA.GetComponent<PlayerMovement>().healthMax;
		barScale = curHealth / maxHealth;
		hpBar = barScale;
	}

	public void HealthDown(float damX)
	{
		if (curHealth > 0) 
		{
			AudioSource.PlayClipAtPoint(hit, playerA.transform.localPosition);

			curHealth = curHealth - damX;
			maxHealth = playerA.GetComponent<PlayerMovement>().healthMax;
			barScale = curHealth / maxHealth;
			hpBar = barScale;
			playerA.GetComponent<PlayerMovement>().health = curHealth;
			/*currentHealth -= 1 + (float)GameAll.getKin() * 0.5f;
			scale = currentHealth / maxHealth;
			HealthBar = HealthBar * scale;*/
		}
		if (curHealth <= 0)
		{
			Death ();
		}
	}

	public void HealthUp(float healX)
	{
		if (curHealth != maxHealth) 
		{
			curHealth = curHealth + healX;
			maxHealth = playerA.GetComponent<PlayerMovement>().healthMax;
			barScale = curHealth / maxHealth;
			hpBar = barScale;
			playerA.GetComponent<PlayerMovement> ().health = curHealth;
		}
	}

	void Death()
	{
		GameAll.updateLevel();
		Application.LoadLevel ("gameOver");
	}
}
