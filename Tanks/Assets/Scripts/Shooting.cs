using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject rocket;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Destroy(Instantiate (rocket, this.transform.position, this.transform.rotation), 1.5f);
			rocket.transform.Translate (Vector3.forward * 0.1f);
		}
	}
}
