using UnityEngine;
using System.Collections;

public class CannonMovement : MonoBehaviour {
	public  GameObject player;
	public GameObject tire;
	//private Vector3 offset;
	//private Vector3 desiredPosition;

	void Start ()
	{
		player.transform.LookAt (new Vector3(0f,0f,tire.transform.position.z));
		//offset = transform.position - player.transform.position;
	}

	void Update ()
	{
		if (Input.GetMouseButton (1)) {
			
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if(hit.collider != null)
			{
				
				player.transform.LookAt (new Vector3(hit.transform.position.x, hit.transform.position.y, 0f));
				//Debug.Log("object clicked: " + hit.transform.position.x + hit.transform.position.y);
			}

		}
	}
}
