using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {

	public float movementSpeed = 0.05f;
	public float rotationSpeed = 1.5f;
	private Transform tankTransforom;

	void Start () {
		tankTransforom = GetComponent<Transform> ();
	}

	void Update () {
		//Going Forward
		if (Input.GetKey("w")) {
			tankTransforom.Translate (Vector2.up * movementSpeed);
			Debug.Log ("Moving Forward");
		}
		//Going Backward
		if (Input.GetKey("s")) {
			tankTransforom.Translate (Vector2.up * -movementSpeed);
			Debug.Log ("Moving Back");
		}
		//Rotating Left
		if (Input.GetKey("a")) {
			if (Input.GetKey("w")) {
				tankTransforom.Rotate (0f, 0f, rotationSpeed);
			}
			else if (Input.GetKey("s")) {
				tankTransforom.Rotate (0f, 0f, -rotationSpeed);
			} else {
				tankTransforom.Rotate (0f, 0f, rotationSpeed);
			}
			Debug.Log ("Rotating Left");
		}
		//Rotating Right
		if (Input.GetKey("d")) { 

			if (Input.GetKey("w")) {
				tankTransforom.Rotate (0f, 0f, -rotationSpeed);
			}
			else if (Input.GetKey("s")) {
				tankTransforom.Rotate (0f, 0f, rotationSpeed);
			} else {
				tankTransforom.Rotate (0f, 0f, -rotationSpeed);
			}
			Debug.Log ("Rotating Right");
		}
	}
}
