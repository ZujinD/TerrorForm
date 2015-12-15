using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public void menuStart()
	{
		Application.LoadLevel ("game");
	}

	public void quiting()
	{
		Application.Quit();
	}
}
