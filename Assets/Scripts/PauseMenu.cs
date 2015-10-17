using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour 
{
	bool isPaused;
	GameObject overlay;
	GameObject resumeBut;
	//GameObject maMenuBut;
	GameObject quitBut;
	GameObject kineticBut;
	GameObject agilityBut;
	GameObject enduranceBut;
	GameObject skillsBut;
	GameObject returnBut;
	GameObject kineticText;
	GameObject agilityText;
	GameObject enduranceText;
	GameObject DNApointsText;
	int DNA;
	Text DNAText;

	void Start()
	{
		isPaused = false;
		overlay = GameObject.Find ("PauseOverlay");
		resumeBut = GameObject.Find ("ResumeButton");
		returnBut = GameObject.Find ("ReturnButton");
		//maMenuBut = GameObject.Find ("MainMenuButton");
		quitBut = GameObject.Find ("QuitButton");
		kineticBut = GameObject.Find ("KineticismButton");
		agilityBut = GameObject.Find ("AgilityButton");
		enduranceBut = GameObject.Find ("EnduranceButton");
		skillsBut = GameObject.Find ("SkillsButton");
		kineticText = GameObject.Find ("KineticismText");
		agilityText = GameObject.Find ("AgilityText");
		enduranceText = GameObject.Find ("EnduranceText");
		DNApointsText = GameObject.Find ("DNAText");
		overlay.SetActive (false);
		resumeBut.SetActive (false);
		returnBut.SetActive (false);
		//maMenuBut.SetActive (false);
		quitBut.SetActive (false);
		kineticBut.SetActive (false);
		agilityBut.SetActive (false);
		enduranceBut.SetActive (false);
		skillsBut.SetActive (false);
		kineticText.SetActive (false);
		agilityText.SetActive (false);
		enduranceText.SetActive (false);
		//DNApointsText.SetActive (false);
		Time.timeScale = 1.0f;
		DNA = GameAll.getDNA();
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(isPaused == false)
			{
				Paused ();
			}
			else
			{
				unPaused();
			}
		}
		DNA = GameAll.getDNA();
		DNAText = DNApointsText.GetComponent<Text> ();
		DNAText.text = "DNA : " +DNA.ToString();
	}

	void Paused()
	{
		Time.timeScale = 0.0f;
		overlay.SetActive (true);
		resumeBut.SetActive (true);
		//maMenuBut.SetActive (true);
		quitBut.SetActive (true);
		skillsBut.SetActive (true);
		isPaused = !isPaused;
	}

	public void unPaused()
	{
		Time.timeScale = 1.0f;
		overlay.SetActive (false);
		resumeBut.SetActive (false);
		//maMenuBut.SetActive (false);
		quitBut.SetActive (false);
		skillsBut.SetActive (false);
		kineticBut.SetActive (false);
		agilityBut.SetActive (false);
		enduranceBut.SetActive (false);
		kineticText.SetActive (false);
		agilityText.SetActive (false);
		enduranceText.SetActive (false);
		returnBut.SetActive (false);
		isPaused = !isPaused;
	}

	public void skillMenu()
	{
		resumeBut.SetActive (false);
		returnBut.SetActive (true);
		//maMenuBut.SetActive (false);
		quitBut.SetActive (false);
		skillsBut.SetActive (false);
		kineticBut.SetActive (true);
		agilityBut.SetActive (true);
		enduranceBut.SetActive (true);
		kineticText.SetActive (true);
		agilityText.SetActive (true);
		enduranceText.SetActive (true);
		//DNApointsText.SetActive (true);
	}

	public void skillToPause()
	{
		resumeBut.SetActive (true);
		returnBut.SetActive (false);
		//maMenuBut.SetActive (true);
		quitBut.SetActive (true);
		skillsBut.SetActive (true);
		kineticBut.SetActive (false);
		agilityBut.SetActive (false);
		enduranceBut.SetActive (false);
		kineticText.SetActive (false);
		agilityText.SetActive (false);
		enduranceText.SetActive (false);
		//DNApointsText.SetActive (false);
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
