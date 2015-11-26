using UnityEngine;
using System.Collections;

public class GameAll : MonoBehaviour 
{
	public static string lastLevel;
	static int DNAPoints;
	static int endValue;
	static int agiValue;
	static int kinValue;
	static int endUp;
	static int agiUp;
	static int kinUp;

	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	void Start () 
	{
		DNAPoints = 0;
		endValue = 0;
		agiValue = 0;
		kinValue = 0;
		endUp = 2;
		agiUp = 2;
		kinUp = 2;
	}

	public static void resetDNA()
	{	
		DNAPoints = 0;
	}

	public static void decreaseDNA(int x)
	{
		DNAPoints = DNAPoints - x;
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

	public static int getEndUp()
	{
		return endUp;
	}

	public static int getAgiUp()
	{
		return agiUp;
	}

	public static int getKinUp()
	{
		return kinUp;
	}

	public static void resetEndUp()
	{
		endUp = 2;
	}
	
	public static void resetAgiUp()
	{
		agiUp = 2;
	}
	
	public static void resetKinUp()
	{
		kinUp = 2;
	}

	public static void setKin(int x)
	{
		kinValue = x;
	}

	public static void addKin(int x)
	{
		kinValue = kinValue + x;
		kinUp = kinUp + 2;
	}

	public static int getKin()
	{
		return kinValue;
	}
	
	public static void setAgi(int x)
	{
		agiValue = x;
	}

	public static void addAgi(int x)
	{
		agiValue = agiValue + x;
		agiUp = agiUp + 2;
	}

	public static int getAgi()
	{
		return agiValue;
	}
	
	public static void setEnd(int x)
	{
		endValue = x;
	}

	public static void addEnd(int x)
	{
		endValue = endValue + x;
		endUp = endUp + 2;
	}
	
	public static int getEnd()
	{
		return endValue;
	}
}
