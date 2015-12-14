using UnityEngine;
using System.Collections;

public class BossAI : MonoBehaviour 
{
	Animator aoeAnim;
	AudioSource soundPlayer;
	public AudioClip sAttackSound;
	public AudioClip lAttackSound;
	public AudioClip startUp;
	GameObject player;
	GameObject colObLarge;
	GameObject colObSmall;
	GameObject colObAll;
	Collider2D playerCol;
	Collider2D colLarge;
	Collider2D colSmall;
	Collider2D colAll;
	Transform target;
	Vector2 currentPlayerPos;
	Vector2 oldPlayerPos;
	float attackDelayRanged = 0;
	float attackDelayMelee = 0;
	float sAoeCooldownTimer = 5.0f;
	float lAoeCooldownTimer = 5.0f;
	float rangedCooldownTimer = 8.0f;
	float aoeActiveTimer = 0.0f;
	bool fightStarted = false;
	bool AoeFire = false;


	void Start () 
	{
		player = GameObject.Find ("Player");
		target = player.transform;
		colObLarge = GameObject.Find ("Ranged Attack");
		colObSmall = GameObject.Find ("AOE Attack");
		colObAll = GameObject.Find ("Large AOE Attack");
		playerCol = player.GetComponent<Collider2D> ();
		colLarge = colObLarge.GetComponent<Collider2D>();
		colSmall = colObSmall.GetComponent<Collider2D>();
		colAll = colObAll.GetComponent<Collider2D>();
		aoeAnim = GameObject.Find ("Large AOE Attack").GetComponent<Animator> ();
		soundPlayer = GameObject.Find ("Main Camera").GetComponent<AudioSource> ();
	}

	void Update () 
	{
		if (colSmall.IsTouching (playerCol) && !colLarge.IsTouching(playerCol)) 
		{
			if(sAoeCooldownTimer <= 0)
			{
				//rockMeleeAttack();
				Debug.Log ("swipe");
				sAoeCooldownTimer = 3.0f;
			}
		}
		if (colLarge.IsTouching (playerCol)) 
		{
			if(rangedCooldownTimer <= 0)
			{
				//rockRangedUpAttack();
				Debug.Log ("ranged");
				rangedCooldownTimer = 3.0f;
			}
		}
		if (colAll.IsTouching (playerCol)) 
		{
			if(fightStarted == false)
			{
				//soundPlayer.PlayOneShot(startUp);
				Debug.Log("started");
				fightStarted = true;
			}
			if(lAoeCooldownTimer <= 0)
			{
				lAoeCooldownTimer = 5.0f;
				rockAoeUpAttack();
				Debug.Log ("AOE");
				/*if (lAoeCooldownTimer <= 15.0f && lAoeCooldownTimer >= 1)
				{
					aoeAttack.SetActive(false);
				}*/
			}

		}
		sAoeCooldownTimer -= Time.deltaTime;
		lAoeCooldownTimer -= Time.deltaTime;
		rangedCooldownTimer -= Time.deltaTime;
		aoeActiveTimer -= Time.deltaTime;
		if(aoeActiveTimer <= 0 && AoeFire == true)
		{
			Debug.Log ("Start");
			for (int i = 0; i < colObAll.transform.childCount; i++)
			{
				Transform blah;
				blah = colObAll.transform.GetChild(i);
				blah.gameObject.SetActive(false);
				Debug.Log ("Child" + i + " is inactive.");
			}
			colObAll.GetComponent<Animator>().enabled = false;
			AoeFire = false;
		}
	}
	
	void rockAoeUpAttack()
	{
		//AudioSource.PlayClipAtPoint(sAttackSound, gameObject.transform.localPosition);
		AoeFire = true;
		for (int i = 0; i < colObAll.transform.childCount; i++)
		{
			Transform blah;
			blah = colObAll.transform.GetChild(i);
			blah.gameObject.SetActive(true);
			Debug.Log ("AGH");
		}
		colObAll.GetComponent<Animator>().enabled = true;
		colObAll.GetComponent<Animator> ().Play ("AOE1", -1, 0.0f);
		aoeActiveTimer = 0.9f;
	}
	void rockRangedUpAttack()
	{
		AudioSource.PlayClipAtPoint(sAttackSound, gameObject.transform.localPosition);

	}
	void rockMeleeAttack()
	{
		AudioSource.PlayClipAtPoint(lAttackSound, gameObject.transform.localPosition);

	}
}
