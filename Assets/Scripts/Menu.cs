using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	GameObject optionsMenu;
	bool optionsOpen;
	AudioSource soundPlayer;
	public AudioClip mmMusic;
	public AudioClip buttonSound;

	void Start ()
	{
		optionsOpen = false;
		optionsMenu = GameObject.Find ("mmOptionsMenu");
		optionsMenu.SetActive (false);
		soundPlayer = GameObject.Find ("Main Camera").GetComponent<AudioSource> ();
		mainMenuMusic ();
	}

	
	void mainMenuMusic()
	{
		soundPlayer.volume = GameAll.musicVolume;
		soundPlayer.loop = true;
		soundPlayer.clip = mmMusic;
		soundPlayer.Play();
	}

	void Update()
	{
		soundPlayer.volume = GameAll.musicVolume;
	}

	public void optionsClick()
	{

		if (optionsOpen == false) 
		{
			optionsMenu.SetActive(true);
		}
		if (optionsOpen == true) 
		{
			optionsMenu.SetActive(false);
		}
		optionsOpen = !optionsOpen;
	}

	public void soundClick()
	{
		gameObject.GetComponent<AudioSource> ().clip = buttonSound;
		gameObject.GetComponent<AudioSource> ().volume = GameAll.sfxVolume;
		gameObject.GetComponent<AudioSource> ().PlayOneShot (buttonSound);
	}

	public void menuStart()
	{
		Application.LoadLevel ("game");
	}

	public void quiting()
	{
		Application.Quit();
	}
}
