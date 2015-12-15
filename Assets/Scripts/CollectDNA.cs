using UnityEngine;
using System.Collections;

public class CollectDNA : MonoBehaviour 
{
	public AudioClip chomp;
	HealthBar hBar;
	GameObject hpbar;

	void Start () 
	{
		hpbar = GameObject.Find ("HealthBar");
		hBar = hpbar.GetComponent<HealthBar> ();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Player") 
		{
			AudioSource.PlayClipAtPoint(chomp, gameObject.transform.localPosition);
			GameAll.incDNA(1);
			hBar.HealthUp(1);
			Destroy(gameObject);
		}
	}
}
