using UnityEngine;
using System.Collections;

public class Slime : MonoBehaviour 
{
	float timer = 3.0f;
	float timer2 = 50.0f;
	SpriteRenderer blob;
	Vector3 scale;

	void Update () 
	{
		timer -= Time.deltaTime;
		timer2 -= Time.deltaTime;
		blob = gameObject.GetComponent<SpriteRenderer> ();
		blob.color = new Color (1f, 1f, 1f, timer/3.0f);
		scale = gameObject.transform.localScale;

		if (scale.x > 0.8f) 
		{
			scale.y = scale.y * timer2 / 50.0f;
			scale.x = scale.x * timer2 / 50.0f;
			gameObject.transform.localScale = scale;
		}

		if(timer <= 0) 
		{
			Destroy(gameObject);
		}
	}
}
