using UnityEngine;
using System.Collections;

public class GameAll : MonoBehaviour 
{
	public static string lastLevel;
	static int DNAPoints;
	static int endValue;
	static int agiValue;
	static int kinValue;

	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	void Start () 
	{
		DNAPoints = 0;
	}

	public static void resetDNA()
	{	
		DNAPoints = 0;
	}

	public static void updateLevel()
	{
		lastLevel = Application.loadedLevelName;
	}

	public static void incDNA(int x)
	{
		DNAPoints = DNAPoints + x;
	}

	public static int getDNA()
	{
		return DNAPoints;
	}

	public static void setKin(int x)
	{
		kinValue = x;
	}

	public static int getKin()
	{
		return kinValue;
	}
	
	public static void setAgi(int x)
	{
		agiValue = x;
	}
	
	public static int getAgi()
	{
		return agiValue;
	}
	
	public static void setEnd(int x)
	{
		endValue = x;
	}
	
	public static int getEnd()
	{
		return endValue;
	}
}
