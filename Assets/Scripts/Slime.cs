using UnityEngine;
using System.Collections;

public class Slime : MonoBehaviour 
{
	float timer = 3.0f;
	SpriteRenderer blob;
	Vector3 scale;

	void Update () 
	{
		timer -= Time.deltaTime;
		blob = gameObject.GetComponent<SpriteRenderer> ();
		blob.color = new Color (1f, 1f, 1f, timer/3.0f);
		scale = gameObject.transform.localScale;

		if (scale.x > 1.0f) 
		{
			scale.y = scale.y * timer / 3.0f;
			scale.x = scale.x * timer / 3.0f;
		}
		gameObject.transform.localScale = scale;
		if(timer <= 0) 
		{
			Destroy(gameObject);
		}
	}
}
