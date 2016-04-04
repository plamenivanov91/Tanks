using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	private Vector3 hotSpot;

	void Start(){
		hotSpot = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		Cursor.SetCursor (cursorTexture, hotSpot, cursorMode);
	}
}
