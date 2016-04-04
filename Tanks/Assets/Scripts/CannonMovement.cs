using UnityEngine;
using System.Collections;

public class CannonMovement : MonoBehaviour
{
	public  GameObject cannon;
	public GameObject tank;
	private Vector3 offset;

	void Start ()
	{
		offset = cannon.transform.position - tank.transform.position;
	}
		
	void Update ()
	{
		RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

		if (hit.collider != null && !hit.collider.CompareTag ("Player")) {
			Vector3 diff = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
			diff.Normalize ();

			float rot_z = Mathf.Atan2 (diff.y, diff.x) * Mathf.Rad2Deg;
			cannon.transform.rotation = Quaternion.Euler (0f, 0f, rot_z - 90);
		}
	}

	void LateUpdate ()
	{
		cannon.transform.position = tank.transform.position + offset;
	}
}
