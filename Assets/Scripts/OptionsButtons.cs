using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsButtons : MonoBehaviour 
{
	public Sprite offNotch;
	public Sprite onNotch;
	Image mNotch1;
	Image mNotch2;
	Image mNotch3;
	Image mNotch4;
	Image mNotch5;
	Image mNotch6;
	Image mNotch7;
	Image mNotch8;
	Image mNotch9;
	Image mNotch10;
	Image aNotch1;
	Image aNotch2;
	Image aNotch3;
	Image aNotch4;
	Image aNotch5;
	Image aNotch6;
	Image aNotch7;
	Image aNotch8;
	Image aNotch9;
	Image aNotch10;
	Image sNotch1;
	Image sNotch2;
	Image sNotch3;
	Image sNotch4;
	Image sNotch5;
	Image sNotch6;
	Image sNotch7;
	Image sNotch8;
	Image sNotch9;
	Image sNotch10;

	void Start () 
	{

	}

	void Update()
	{
		mNotch1 = GameObject.Find ("musicNotch1").GetComponent<Image>();
		mNotch2 = GameObject.Find ("musicNotch2").GetComponent<Image>();
		mNotch3 = GameObject.Find ("musicNotch3").GetComponent<Image>();
		mNotch4 = GameObject.Find ("musicNotch4").GetComponent<Image>();
		mNotch5 = GameObject.Find ("musicNotch5").GetComponent<Image>();
		mNotch6 = GameObject.Find ("musicNotch6").GetComponent<Image>();
		mNotch7 = GameObject.Find ("musicNotch7").GetComponent<Image>();
		mNotch8 = GameObject.Find ("musicNotch8").GetComponent<Image>();
		mNotch9 = GameObject.Find ("musicNotch9").GetComponent<Image>();
		mNotch10 = GameObject.Find ("musicNotch10").GetComponent<Image>();
		sNotch1 = GameObject.Find ("sfxNotch1").GetComponent<Image>();
		sNotch2 = GameObject.Find ("sfxNotch2").GetComponent<Image>();
		sNotch3 = GameObject.Find ("sfxNotch3").GetComponent<Image>();
		sNotch4 = GameObject.Find ("sfxNotch4").GetComponent<Image>();
		sNotch5 = GameObject.Find ("sfxNotch5").GetComponent<Image>();
		sNotch6 = GameObject.Find ("sfxNotch6").GetComponent<Image>();
		sNotch7 = GameObject.Find ("sfxNotch7").GetComponent<Image>();
		sNotch8 = GameObject.Find ("sfxNotch8").GetComponent<Image>();
		sNotch9 = GameObject.Find ("sfxNotch9").GetComponent<Image>();
		sNotch10 = GameObject.Find ("sfxNotch10").GetComponent<Image>();
		aNotch1 = GameObject.Find ("ambienceNotch1").GetComponent<Image>();
		aNotch2 = GameObject.Find ("ambienceNotch2").GetComponent<Image>();
		aNotch3 = GameObject.Find ("ambienceNotch3").GetComponent<Image>();
		aNotch4 = GameObject.Find ("ambienceNotch4").GetComponent<Image>();
		aNotch5 = GameObject.Find ("ambienceNotch5").GetComponent<Image>();
		aNotch6 = GameObject.Find ("ambienceNotch6").GetComponent<Image>();
		aNotch7 = GameObject.Find ("ambienceNotch7").GetComponent<Image>();
		aNotch8 = GameObject.Find ("ambienceNotch8").GetComponent<Image>();
		aNotch9 = GameObject.Find ("ambienceNotch9").GetComponent<Image>();
		aNotch10 = GameObject.Find ("ambienceNotch10").GetComponent<Image>();

		if (GameAll.ambientVolume >= 0.1f) 
		{
			aNotch1.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.2f) 
		{
			aNotch2.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.3f) 
		{
			aNotch3.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.4f) 
		{
			aNotch4.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.5f) 
		{
			aNotch5.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.6f) 
		{
			aNotch6.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.7f) 
		{
			aNotch7.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.8f) 
		{
			aNotch8.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 0.9f) 
		{
			aNotch9.sprite = onNotch;
		}
		if (GameAll.ambientVolume >= 1.0f) 
		{
			aNotch10.sprite = onNotch;
		}
		
		if (GameAll.ambientVolume <= 0.9f) 
		{
			aNotch10.sprite = offNotch;
		}
		
		if (GameAll.ambientVolume <= 0.8f) 
		{
			aNotch10.sprite = offNotch;
			aNotch9.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.7f) 
		{
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch10.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.6f) 
		{
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch7.sprite = offNotch;
			aNotch10.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.5f) 
		{
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch7.sprite = offNotch;
			aNotch6.sprite = offNotch;
			aNotch10.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.4f) 
		{
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch7.sprite = offNotch;
			aNotch6.sprite = offNotch;
			aNotch5.sprite = offNotch;
			aNotch10.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.3f) 
		{
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch7.sprite = offNotch;
			aNotch6.sprite = offNotch;
			aNotch5.sprite = offNotch;
			aNotch4.sprite = offNotch;
			aNotch10.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.2f) 
		{
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch7.sprite = offNotch;
			aNotch6.sprite = offNotch;
			aNotch5.sprite = offNotch;
			aNotch4.sprite = offNotch;
			aNotch3.sprite = offNotch;
			aNotch10.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.1f) 
		{
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch7.sprite = offNotch;
			aNotch6.sprite = offNotch;
			aNotch5.sprite = offNotch;
			aNotch4.sprite = offNotch;
			aNotch3.sprite = offNotch;
			aNotch2.sprite = offNotch;
			aNotch10.sprite = offNotch;
		}
		if (GameAll.ambientVolume <= 0.0f) 
		{
			aNotch10.sprite = offNotch;
			aNotch9.sprite = offNotch;
			aNotch8.sprite = offNotch;
			aNotch7.sprite = offNotch;
			aNotch6.sprite = offNotch;
			aNotch5.sprite = offNotch;
			aNotch4.sprite = offNotch;
			aNotch3.sprite = offNotch;
			aNotch2.sprite = offNotch;
			aNotch1.sprite = offNotch;
		}

		if (GameAll.sfxVolume >= 0.1f) 
		{
			sNotch1.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.2f) 
		{
			sNotch2.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.3f) 
		{
			sNotch3.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.4f) 
		{
			sNotch4.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.5f) 
		{
			sNotch5.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.6f) 
		{
			sNotch6.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.7f) 
		{
			sNotch7.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.8f) 
		{
			sNotch8.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 0.9f) 
		{
			sNotch9.sprite = onNotch;
		}
		if (GameAll.sfxVolume >= 1.0f) 
		{
			sNotch10.sprite = onNotch;
		}
		
		if (GameAll.sfxVolume <= 0.9f) 
		{
			sNotch10.sprite = offNotch;
		}
		
		if (GameAll.sfxVolume <= 0.8f) 
		{
			sNotch10.sprite = offNotch;
			sNotch9.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.7f) 
		{
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch10.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.6f) 
		{
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch7.sprite = offNotch;
			sNotch10.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.5f) 
		{
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch7.sprite = offNotch;
			sNotch6.sprite = offNotch;
			sNotch10.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.4f) 
		{
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch7.sprite = offNotch;
			sNotch6.sprite = offNotch;
			sNotch5.sprite = offNotch;
			sNotch10.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.3f) 
		{
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch7.sprite = offNotch;
			sNotch6.sprite = offNotch;
			sNotch5.sprite = offNotch;
			sNotch4.sprite = offNotch;
			sNotch10.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.2f) 
		{
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch7.sprite = offNotch;
			sNotch6.sprite = offNotch;
			sNotch5.sprite = offNotch;
			sNotch4.sprite = offNotch;
			sNotch3.sprite = offNotch;
			sNotch10.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.1f) 
		{
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch7.sprite = offNotch;
			sNotch6.sprite = offNotch;
			sNotch5.sprite = offNotch;
			sNotch4.sprite = offNotch;
			sNotch3.sprite = offNotch;
			sNotch2.sprite = offNotch;
			sNotch10.sprite = offNotch;
		}
		if (GameAll.sfxVolume <= 0.0f) 
		{
			sNotch10.sprite = offNotch;
			sNotch9.sprite = offNotch;
			sNotch8.sprite = offNotch;
			sNotch7.sprite = offNotch;
			sNotch6.sprite = offNotch;
			sNotch5.sprite = offNotch;
			sNotch4.sprite = offNotch;
			sNotch3.sprite = offNotch;
			sNotch2.sprite = offNotch;
			sNotch1.sprite = offNotch;
		}

		if (GameAll.musicVolume >= 0.1f) 
		{
			mNotch1.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.2f) 
		{
			mNotch2.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.3f) 
		{
			mNotch3.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.4f) 
		{
			mNotch4.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.5f) 
		{
			mNotch5.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.6f) 
		{
			mNotch6.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.7f) 
		{
			mNotch7.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.8f) 
		{
			mNotch8.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 0.9f) 
		{
			mNotch9.sprite = onNotch;
		}
		if (GameAll.musicVolume >= 1.0f) 
		{
			mNotch10.sprite = onNotch;
		}

		if (GameAll.musicVolume <= 0.9f) 
		{
			mNotch10.sprite = offNotch;
		}

		if (GameAll.musicVolume <= 0.8f) 
		{
			mNotch10.sprite = offNotch;
			mNotch9.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.7f) 
		{
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch10.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.6f) 
		{
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch7.sprite = offNotch;
			mNotch10.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.5f) 
		{
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch7.sprite = offNotch;
			mNotch6.sprite = offNotch;
			mNotch10.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.4f) 
		{
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch7.sprite = offNotch;
			mNotch6.sprite = offNotch;
			mNotch5.sprite = offNotch;
			mNotch10.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.3f) 
		{
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch7.sprite = offNotch;
			mNotch6.sprite = offNotch;
			mNotch5.sprite = offNotch;
			mNotch4.sprite = offNotch;
			mNotch10.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.2f) 
		{
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch7.sprite = offNotch;
			mNotch6.sprite = offNotch;
			mNotch5.sprite = offNotch;
			mNotch4.sprite = offNotch;
			mNotch3.sprite = offNotch;
			mNotch10.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.1f) 
		{
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch7.sprite = offNotch;
			mNotch6.sprite = offNotch;
			mNotch5.sprite = offNotch;
			mNotch4.sprite = offNotch;
			mNotch3.sprite = offNotch;
			mNotch2.sprite = offNotch;
			mNotch10.sprite = offNotch;
		}
		if (GameAll.musicVolume <= 0.0f) 
		{
			mNotch10.sprite = offNotch;
			mNotch9.sprite = offNotch;
			mNotch8.sprite = offNotch;
			mNotch7.sprite = offNotch;
			mNotch6.sprite = offNotch;
			mNotch5.sprite = offNotch;
			mNotch4.sprite = offNotch;
			mNotch3.sprite = offNotch;
			mNotch2.sprite = offNotch;
			mNotch1.sprite = offNotch;
		}
	}

	public void musicVolUpOnClick()
	{
		GameAll.musicVolumeUp ();
	}

	public void musicVolDownOnClick()
	{
		GameAll.musicVolumeDown ();
	}

	public void ambVolUpOnClick()
	{
		GameAll.ambientVolumeUp ();
	}
	
	public void ambVolDownOnClick()
	{
		GameAll.ambientVolumeDown ();
	}	

	public void sfxVolUpOnClick()
	{
		GameAll.sfxVolumeUp ();
	}
	
	public void sfxVolDownOnClick()
	{
		GameAll.sfxVolumeDown ();
	}	

}
