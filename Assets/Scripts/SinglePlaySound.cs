using UnityEngine;
using System.Collections;

public class SinglePlaySound : MonoBehaviour 
{
	AudioSource soundPlayer;
	public AudioClip sfx;

	void Start () 
	{
		soundPlayer = GameObject.Find ("Main Camera").GetComponent<AudioSource> ();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" ) 
		{
			soundPlayer.PlayOneShot(sfx);
		}
	}
}
