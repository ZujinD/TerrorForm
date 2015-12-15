using UnityEngine;
using System.Collections;

public class SkillButton : MonoBehaviour 
{
	GameObject playerA;

	void Start()
	{
		playerA = GameObject.Find ("Player");
	}

	public void endOnClick()
	{
		if (GameAll.getDNA() >= GameAll.getEndUp()) 
		{
			GameAll.decreaseDNA(GameAll.getEndUp());
			GameAll.addEnd (1);
			playerA.GetComponent<PlayerMovement>().incHealth();
		}
	}

	public void agiOnClick()
	{
		if (GameAll.getDNA() >= GameAll.getAgiUp()) 
		{
			GameAll.decreaseDNA(GameAll.getAgiUp());
			GameAll.addAgi (1);
			PlayerMovement.incSpeed();
		}
	}

	public void kinOnClick()
	{
		if (GameAll.getDNA() >= GameAll.getKinUp()) 
		{
			GameAll.decreaseDNA(GameAll.getKinUp());
			GameAll.addKin (1);
		}
	}
}
