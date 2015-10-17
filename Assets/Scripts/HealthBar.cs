using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour 
{
	Vector3 scale;
	int playHealth;
	public int healthMax;
	GameObject playerA;
	float segment;
	public AudioClip hit;
	// Use this for initialization
	void Start () 
	{
		playerA = GameObject.Find ("Player");
		healthMax = playerA.GetComponent<PlayerMovement>().health;
		playHealth = playerA.GetComponent<PlayerMovement>().health;
		scale = transform.localScale;
		segment = scale.x / (float)healthMax;
	}

	public void HealthDown(int damX)
	{
		if (playHealth > 0) 
		{
			AudioSource.PlayClipAtPoint(hit, playerA.transform.localPosition);
			playHealth = playHealth - damX;
			playerA.GetComponent<PlayerMovement> ().health = playHealth;
			scale.x = segment * (float)playHealth;
			transform.localScale = scale;
		}
		if (playHealth <= 0)
		{
			Death ();
		}
	}

	public void HealthUp(int healX)
	{
		if (playHealth != healthMax) 
		{
			playHealth = playHealth + healX;
			playerA.GetComponent<PlayerMovement> ().health = playHealth;
			scale.x = segment * (float)playHealth;
			transform.localScale = scale;
		}
	}

	void Death()
	{
		GameAll.updateLevel();
		Application.LoadLevel ("gameOver");
	}
}
