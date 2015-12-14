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
	public static float sfxVolume = 1.0f;
	public static float musicVolume = 1.0f;
	public static float ambientVolume = 1.0f;
	static int sv;
	static int mv;
	static int av;
	public static bool pauseMenuUP = false;

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

	public static void sfxVolumeUp()
	{
		sv = System.Convert.ToInt32(sfxVolume * 10);
		if (sv <= 9) 
		{
			sv = sv + 1;
			sfxVolume = (float)sv / 10;
			Debug.Log(sfxVolume);
		} 
	}
	public static void sfxVolumeDown()
	{
		sv = System.Convert.ToInt32(sfxVolume * 10);
		if (sv >= 1) 
		{
			sv = sv - 1;
			sfxVolume = (float)sv / 10;
			Debug.Log(sfxVolume);
		} 
	}
	public static void musicVolumeUp()
	{
		mv = System.Convert.ToInt32(musicVolume * 10);
		if (mv <= 9) 
		{
			mv = mv + 1;
			musicVolume = (float)mv / 10;
			Debug.Log(musicVolume);
		}
	}
	public static void musicVolumeDown()
	{
		mv = System.Convert.ToInt32(musicVolume * 10);
		if (mv >= 1) 
		{
			mv = mv - 1;
			musicVolume = (float)mv / 10;
			Debug.Log(musicVolume);
		} 
	}
	public static void ambientVolumeUp()
	{
		av = System.Convert.ToInt32(ambientVolume * 10);
		if (av <= 9) 
		{
			av = av + 1;
			ambientVolume = (float)av / 10;
			Debug.Log(ambientVolume);
		} 
	}
	public static void ambientVolumeDown()
	{
		av = System.Convert.ToInt32(ambientVolume * 10);
		if (av >= 1) 
		{
			av = av - 1;
			ambientVolume = (float)av / 10;
			Debug.Log(ambientVolume);
		} 
	}
}
