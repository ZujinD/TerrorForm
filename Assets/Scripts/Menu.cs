using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour 
{
	GameObject optionsMenu;
	GameObject but1;
	GameObject but2;
	GameObject but3;
	bool optionsOpen;
	AudioSource soundPlayer;
	public AudioClip mmMusic;
	public AudioClip buttonSound;
	bool clicked;
	float screenTimer1;
	bool timerDone;
	float screenTimer2;
	float screenTimer3;
	GameObject imageBG;
	public Sprite sc1;
	public Sprite sc2;
	public Sprite sc3;

	void Start ()
	{
		but1 = GameObject.Find ("StartButton");
		but2 = GameObject.Find ("OptionsButton");
		but3 = GameObject.Find ("QuitButton");
		imageBG = GameObject.Find ("Image");
		screenTimer1 = 10.0f;
		screenTimer2 = 10.0f;
		screenTimer3 = 10.0f;
		clicked = false;
		timerDone = false;
		screenTimer1 = 0;
		screenTimer2 = 0;
		screenTimer3 = 0;
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
		Debug.Log (screenTimer1 + " " + screenTimer2 + " " + screenTimer3);
		soundPlayer.volume = GameAll.musicVolume;
		if (screenTimer1 > 0.0f && clicked == true) 
		{
			screenTimer1 -= Time.deltaTime;
		}
		if (screenTimer2 > 0.0f && screenTimer1 <= 0.0f) 
		{
			screenTimer2 -= Time.deltaTime;
			imageBG.GetComponent<Image> ().sprite = sc2;
		}
		if (screenTimer3 > 0.0f && screenTimer2 <= 0.0f) 
		{
			screenTimer3 -= Time.deltaTime;
			imageBG.GetComponent<Image> ().sprite = sc3;
			timerDone = true;
		}
		if (timerDone == true && screenTimer3 <= 0.0f) 
		{
			Application.LoadLevel ("game");
		}
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
		but1.SetActive (false);
		but2.SetActive (false);
		but3.SetActive (false);
		screenTimer1 = 1.8f;
		screenTimer2 = 1.8f;
		screenTimer3 = 0.2f;
		imageBG.GetComponent<Image> ().sprite = sc1;
		clicked = true;
		//Application.LoadLevel ("game");
	}

	public void quiting()
	{
		Application.Quit();
	}
}
