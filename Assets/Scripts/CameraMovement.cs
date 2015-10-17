using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
	private float rightBound;
	private float leftBound;
	private float topBound;
	private float bottomBound;
	private Vector3 pos;
	private Transform target;
	private SpriteRenderer spriteBounds;
	public Camera cam;

	void Start () 
	{
		cam = GameObject.Find ("Main Camera").GetComponent<Camera>();
		float vertExtent = cam.orthographicSize;  
		float horzExtent = vertExtent * Screen.width / Screen.height;
		spriteBounds = GameObject.Find("Ground Compiled").GetComponent<SpriteRenderer>();
		target = GameObject.FindWithTag("Player").transform;
		leftBound = (float)(horzExtent - spriteBounds.sprite.bounds.size.x / 2.0f);
		rightBound = (float)(spriteBounds.sprite.bounds.size.x / 2.0f - horzExtent);
		bottomBound = (float)(vertExtent - spriteBounds.sprite.bounds.size.y / 2.0f);
		topBound = (float)(spriteBounds.sprite.bounds.size.y  / 2.0f - vertExtent);
	}

	void Update () 
	{
		var pos = new Vector3(target.position.x, target.position.y, transform.position.z);
		pos.x = Mathf.Clamp(pos.x, leftBound, rightBound);
		pos.y = Mathf.Clamp(pos.y, bottomBound, topBound);
		transform.position = pos;
	}
}
