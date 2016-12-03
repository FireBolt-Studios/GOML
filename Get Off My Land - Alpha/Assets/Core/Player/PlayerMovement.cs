using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public Camera mainCamera;
	private Vector3 mousePosition;

	public Transform character;
	public Transform cursorRef;

	void LookAtCursor ()
	{
		cursorRef.position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
		cursorRef.position = new Vector3(cursorRef.position.x,1,cursorRef.position.z);

		character.LookAt(cursorRef);
		character.localEulerAngles = new Vector3(90,character.localEulerAngles.y-90,0);

	}

	void Update ()
	{
		LookAtCursor();
	}
}
