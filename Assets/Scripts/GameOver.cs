using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{
	public void retry()
	{
		Application.LoadLevel (GameAll.lastLevel);
		GameAll.resetDNA();
	}
	public void mainMenu()
	{
		Application.LoadLevel ("startMenu");
		GameAll.resetDNA ();
	}
	public void quiting()
	{
		Application.Quit();
	}
}
