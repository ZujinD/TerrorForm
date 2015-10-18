using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
	private float rightBound;
	private float leftBound;
	private float topBound;
	private float bottomBound;
	private Vector3 pos;
	private SpriteRenderer spriteBounds;
	private Camera cam;

	void Start () 
	{
		cam = GameObject.Find ("Main Camera").GetComponent<Camera>();
		float vertExtent = cam.orthographicSize;  
		float horzExtent = vertExtent * Screen.width / Screen.height;
		spriteBounds = GameObject.Find("Background").GetComponent<SpriteRenderer>();
		leftBound = (float)(horzExtent - spriteBounds.sprite.bounds.size.x / 2.0f);
		rightBound = (float)(spriteBounds.sprite.bounds.size.x / 2.0f - horzExtent);
		bottomBound = (float)(vertExtent - spriteBounds.sprite.bounds.size.y / 2.0f);
		topBound = (float)(spriteBounds.sprite.bounds.size.y  / 2.0f - vertExtent);
	}

	void Update () 
	{
		pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		pos.x = Mathf.Clamp(pos.x, leftBound, rightBound);
		pos.y = Mathf.Clamp(pos.y, bottomBound, topBound);
		transform.position = pos;
		Debug.Log (pos.x + ", " + pos.y + ", " + pos.z);
	}
}
