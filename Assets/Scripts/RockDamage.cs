using UnityEngine;
using System.Collections;

public class RockDamage : MonoBehaviour 
{
	GameObject hpbar;
	HealthBar healthbar;

	void Start () 
	{
		hpbar = GameObject.Find ("HealthBar");
		healthbar = hpbar.GetComponent<HealthBar> ();
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" ) 
		{
			healthbar.HealthDown(1);
			gameObject.SetActive(false);
		}
	}
}
