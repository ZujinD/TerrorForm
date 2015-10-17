using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour 
{
	private Vector3 mousePosition;
	private Camera cam;

	void Update () 
	{
		cam = Camera.main;
		mousePosition = Input.mousePosition;
		mousePosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z - cam.transform.position.z));
		transform.eulerAngles = new Vector3(0,0,Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x))*Mathf.Rad2Deg);
	}
}
