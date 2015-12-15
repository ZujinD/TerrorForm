using UnityEngine;
using System.Collections;

public class RepeatSound : MonoBehaviour 
{
	AudioSource soundPlayer;
	public AudioClip sfx;
	
	void Start () 
	{
		soundPlayer = gameObject.GetComponent<AudioSource> ();
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" ) 
		{
			soundPlayer.loop = true;
			soundPlayer.clip = sfx;
			soundPlayer.Play();
		}
	}
}