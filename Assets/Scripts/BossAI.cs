using UnityEngine;
using System.Collections;

public class BossAI : MonoBehaviour 
{
	Animator aoeAnim;
	AudioSource soundPlayer;
	public AudioClip sAttackSound;
	public AudioClip lAttackSound;
	public AudioClip startUp;
	public AudioClip attackHit;
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
	public float maxHealth;
	public float currentHealth;
	float HealthBar;
	float startHealthBar;
	GameObject bar;
	Vector3 temp;
	float scale;
	Quaternion barRotation;
	bool isColliding;
	GameObject Rocks1;
	GameObject Rocks2;


	void Start () 
	{
		bar = gameObject.transform.FindChild ("BossHPBar").gameObject;
		temp = bar.transform.localScale;
		startHealthBar = temp.x;
		HealthBar = startHealthBar;
		currentHealth = maxHealth;
		player = GameObject.Find ("Player");
		target = player.transform;
		colObLarge = GameObject.Find ("Ranged Attack");
		colObSmall = GameObject.Find ("AOE Attack");
		colObAll = GameObject.Find ("Large AOE Attack");
		Rocks1 = GameObject.Find ("Blockage1");
		Rocks2 = GameObject.Find ("Blockage2");
		colObAll = GameObject.Find ("Large AOE Attack");
		playerCol = player.GetComponent<Collider2D> ();
		colLarge = colObLarge.GetComponent<Collider2D>();
		colSmall = colObSmall.GetComponent<Collider2D>();
		colAll = colObAll.GetComponent<Collider2D>();
		aoeAnim = GameObject.Find ("Large AOE Attack").GetComponent<Animator> ();
		soundPlayer = gameObject.GetComponent<AudioSource> ();
	}

	void Update () 
	{
		barRotation = transform.localRotation;
		barRotation.x = 0;
		transform.localRotation = barRotation;
		temp.x = HealthBar;
		bar.transform.localScale = temp;
		isColliding = false;

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
				soundPlayer.PlayOneShot(startUp);
				Debug.Log("started");
				for (int i = 0; i < Rocks2.transform.childCount; i++)
				{
					Transform blah;
					blah = Rocks2.transform.GetChild(i);
					blah.gameObject.SetActive(true);
				}
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
			for (int i = 0; i < colObAll.transform.childCount; i++)
			{
				Transform blah;
				blah = colObAll.transform.GetChild(i);
				blah.gameObject.SetActive(false);
			}
			colObAll.GetComponent<Animator>().enabled = false;
			AoeFire = false;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(isColliding) return;
		isColliding = true;
		if (col.gameObject.name == "AttackTentacle" && currentHealth > 0) 
		{
			soundPlayer.PlayOneShot(attackHit, GameAll.sfxVolume);
			currentHealth -= 1 + (float)GameAll.getKin() * 0.5f;
			scale = currentHealth / maxHealth;
			HealthBar = startHealthBar * scale;
			if(gameObject.name != "Player")
			{
				if(currentHealth <= 0)
				{
					for (int i = 0; i < Rocks1.transform.childCount; i++)
					{
						Transform blah;
						blah = Rocks1.transform.GetChild(i);
						blah.gameObject.SetActive(false);
					}
					for (int i = 0; i < Rocks2.transform.childCount; i++)
					{
						Transform blah;
						blah = Rocks2.transform.GetChild(i);
						blah.gameObject.SetActive(false);
					}
					AudioSource.PlayClipAtPoint(attackHit, gameObject.transform.localPosition, GameAll.sfxVolume);
					Destroy(gameObject);
				}
			}
		}
		
	}

	void rockAoeUpAttack()
	{
		AoeFire = true;
		for (int i = 0; i < colObAll.transform.childCount; i++)
		{
			Transform blah;
			blah = colObAll.transform.GetChild(i);
			blah.gameObject.SetActive(true);
		}
		colObAll.GetComponent<Animator>().enabled = true;
		colObAll.GetComponent<Animator> ().Play ("AOE1", -1, 0.0f);
		aoeActiveTimer = 0.9f;
	}
	void rockRangedUpAttack()
	{
		AudioSource.PlayClipAtPoint(sAttackSound, gameObject.transform.localPosition, GameAll.sfxVolume);

	}
	void rockMeleeAttack()
	{
		AudioSource.PlayClipAtPoint(lAttackSound, gameObject.transform.localPosition, GameAll.sfxVolume);

	}
}
