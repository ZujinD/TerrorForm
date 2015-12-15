using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour 
{
	bool isPaused;
	GameObject overlay;
	GameObject resumeBut;
	GameObject quitBut;
	GameObject optionsBut;
	GameObject skillsBut;
	GameObject DNApointsText;
	GameObject EndLev;
	GameObject AgiLev;
	GameObject KinLev;
	GameObject endUpText;
	GameObject agiUpText;
	GameObject kinUpText;
	GameObject skillsMenu;
	GameObject optionsMenu;
	int DNA;
	Text DNAText;
	Text endText;
	Text agiText;
	Text kinText;
	Text endToUpgrade;
	Text agiToUpgrade;
	Text kinToUpgrade;
	public AudioClip buttonSound;

	void Start()
	{
		isPaused = false;
		overlay = GameObject.Find ("PauseOverlay");
		resumeBut = GameObject.Find ("ResumeButton");
		quitBut = GameObject.Find ("QuitButton");
		optionsBut = GameObject.Find ("OptionsButton");
		skillsBut = GameObject.Find ("SkillsButton");
		DNApointsText = GameObject.Find ("DNAText");
		EndLev = GameObject.Find ("EndLevel");
		AgiLev = GameObject.Find ("AgiLevel");
		KinLev = GameObject.Find ("KinLevel");
		endUpText = GameObject.Find ("EndUpgText");
		agiUpText = GameObject.Find ("AgiUpgText");
		kinUpText = GameObject.Find ("KinUpgText");
		skillsMenu = GameObject.Find ("SkillsMenu");
		optionsMenu = GameObject.Find ("OptionsMenu");
		overlay.SetActive (false);
		resumeBut.SetActive (false);
		skillsBut.SetActive (false);
		quitBut.SetActive (false);
		optionsBut.SetActive (false);
		Time.timeScale = 1.0f;
		DNA = GameAll.getDNA();
		GameAll.resetAgiUp ();
		GameAll.resetEndUp ();
		GameAll.resetKinUp ();
		skillsMenu.SetActive (false);
		optionsMenu.SetActive (false);
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(isPaused == false)
			{
				Paused();
			}
			else
			{
				unPaused();
			}
		}
		DNA = GameAll.getDNA();
		DNAText = DNApointsText.GetComponent<Text> ();
		DNAText.text = "DNA : " +DNA.ToString();
		endText = EndLev.GetComponent<Text> ();
		agiText = AgiLev.GetComponent<Text> ();
		kinText = KinLev.GetComponent<Text> ();
		endText.text = GameAll.getEnd().ToString();
		agiText.text = GameAll.getAgi().ToString();
		kinText.text = GameAll.getKin().ToString();
		endToUpgrade = endUpText.GetComponent<Text> ();
		agiToUpgrade = agiUpText.GetComponent<Text> ();
		kinToUpgrade = kinUpText.GetComponent<Text> ();
		endToUpgrade.text = "DNA to upgrade : " + GameAll.getEndUp().ToString();
		agiToUpgrade.text = "DNA to upgrade : " + GameAll.getAgiUp().ToString();
		kinToUpgrade.text = "DNA to upgrade : " + GameAll.getKinUp().ToString();
	}

	void Paused()
	{
		Time.timeScale = 0.0f;
		overlay.SetActive (true);
		resumeBut.SetActive (true);
		quitBut.SetActive (true);
		skillsBut.SetActive (true);
		optionsBut.SetActive (true);
		isPaused = !isPaused;
		GameAll.pauseMenuUP = true;
	}

	public void unPaused()
	{
		Time.timeScale = 1.0f;
		overlay.SetActive (false);
		resumeBut.SetActive (false);
		quitBut.SetActive (false);
		skillsBut.SetActive (false);
		optionsBut.SetActive (false);
		skillsMenu.SetActive (false);
		optionsMenu.SetActive (false);
		isPaused = !isPaused;
		GameAll.pauseMenuUP = false;
	}

	public void skillMenu()
	{
		resumeBut.SetActive (false);
		quitBut.SetActive (false);
		skillsBut.SetActive (false);
		optionsBut.SetActive (false);
		skillsMenu.SetActive (true);
	}

	public void optionMenu()
	{
		resumeBut.SetActive (false);
		quitBut.SetActive (false);
		skillsBut.SetActive (false);
		optionsBut.SetActive (false);
		optionsMenu.SetActive (true);
	}


	public void skillToPause()
	{
		resumeBut.SetActive (true);
		quitBut.SetActive (true);
		skillsBut.SetActive (true);
		optionsBut.SetActive (true);
		skillsMenu.SetActive (false);
	}

	public void optionsToPause()
	{
		resumeBut.SetActive (true);
		quitBut.SetActive (true);
		skillsBut.SetActive (true);
		optionsBut.SetActive (true);
		optionsMenu.SetActive (false);
	}

	public void soundClick()
	{
		gameObject.GetComponent<AudioSource> ().clip = buttonSound;
		gameObject.GetComponent<AudioSource> ().volume = GameAll.sfxVolume;
		gameObject.GetComponent<AudioSource> ().PlayOneShot (buttonSound);
	}

	public void mainMenu()
	{
		Application.LoadLevel ("startMenu");
	}

	public void quiting()
	{
		Application.Quit();
	}
}
