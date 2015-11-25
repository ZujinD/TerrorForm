using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
	AudioSource musicPlayer;
	public AudioClip oneSong;
	public AudioClip twoSong;
	public AudioClip threeSong;
	public AudioClip fourSong;
	public AudioClip fiveSong;
	public AudioClip sixSong;
	public AudioClip sevenSong;
	public AudioClip eightSong;
	public AudioClip nineSong;
	public AudioClip tenSong;
	public AudioClip elevenSong;
	AudioClip[] songs;
	float volumeFull = 1.0f;
	float volumeBottom  = 0.0f;
	AudioClip currentSong;
	AudioClip nextSong;
	float songEnd;
	float songStart;
	float songPlayEnd;

	void Start () 
	{
		musicPlayer = gameObject.GetComponent<AudioSource> ();
		songs = new AudioClip[11];
		songs [0] = oneSong;
		songs [1] = twoSong;
		songs [2] = threeSong;
		songs [3] = fourSong;
		songs [4] = fiveSong;
		songs [5] = sixSong;
		songs [6] = sevenSong;
		songs [7] = eightSong;
		songs [8] = nineSong;
		songs [9] = tenSong;
		songs [10] = elevenSong;
		currentSong = songs [0];
		startPlayer ();
		songStart = Time.fixedTime;
		songPlayEnd = currentSong.length;
	}

	void Update ()
	{
		songEnd = currentSong.length - currentSong.length / 10;
		findNextSong();
		if (songStart + songEnd == Time.fixedTime) 
		{
			//fadeOut();
		}
		if (songPlayEnd <= Time.fixedTime) 
		{
			playNextSong();
			Debug.Log("Next");
		}
		Debug.Log(Time.fixedTime + " " + songPlayEnd);
	}

	void startPlayer ()
	{
		musicPlayer.PlayOneShot (currentSong);
	}

	void findNextSong()
	{
		for (int i = 0; i < songs.Length - 1; i ++) 
		{
			if (currentSong == songs [10]) 
			{
				nextSong = songs [0];
			} 
			else if (currentSong == songs [i]) 
			{
				nextSong = songs[i + 1];
			}
		}
	}

	void playNextSong ()
	{
		currentSong = nextSong;
		songStart = Time.fixedTime;
		songPlayEnd = Time.fixedTime + currentSong.length;
		musicPlayer.PlayOneShot (currentSong);
		//fadeIn ();

	}

	void fadeIn() 
	{
		if (volumeBottom < 1f) 
		{
			volumeBottom += 0.1f * Time.deltaTime;
			musicPlayer.volume = volumeBottom;
		}
	}
	
	void fadeOut() 
	{
		if (volumeFull > 0.1f) 
		{
			volumeFull -= 0.1f * Time.deltaTime;
			musicPlayer.volume = volumeFull;
			if(musicPlayer.volume == 0)
			{
				musicPlayer.Stop();
			}
		}	
	}
}
