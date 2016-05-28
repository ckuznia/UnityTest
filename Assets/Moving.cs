using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour {

	private float speed = 8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// If RIGHT ARROW is pressed
		if(Input.GetKey(KeyCode.RightArrow)) {
			// Getting current position
			Vector2 pos = this.transform.position;
			// Changing position
			pos.x += speed * Time.deltaTime;
			// Updating position
			this.transform.position = pos;
		}
		// If LEFT ARROW is pressed
		if(Input.GetKey(KeyCode.LeftArrow)) {
			// Getting current position
			Vector2 pos = this.transform.position;
			// Changing position
			pos.x -= speed * Time.deltaTime;
			// Updating position
			this.transform.position = pos;
		}
		// If UP ARROW is pressed
		if(Input.GetKey(KeyCode.UpArrow)) {
			// Getting current position
			Vector2 pos = this.transform.position;
			// Changing position
			pos.y += speed * Time.deltaTime;
			// Updating position
			this.transform.position = pos;
		}
		// If DOWN ARROW is pressed
		if(Input.GetKey(KeyCode.DownArrow)) {
			// Getting current position
			Vector2 pos = this.transform.position;
			// Changing position
			pos.y -= speed * Time.deltaTime;
			// Updating position
			this.transform.position = pos;
		}
	}
}
