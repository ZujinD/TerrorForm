using UnityEngine;
using System.Collections;

public class AmbientController : MonoBehaviour 
{
	AudioSource soundPlayer;
	public AudioClip ambient;
	
	void Start () 
	{
		soundPlayer = gameObject.GetComponent<AudioSource> ();
		soundPlayer.volume = GameAll.ambientVolume;
		soundPlayer.loop = true;
		soundPlayer.clip = ambient;
		soundPlayer.Play ();
	}
	void Update ()
	{
		soundPlayer.volume = GameAll.ambientVolume;
	}
}
