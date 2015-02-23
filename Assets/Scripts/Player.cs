using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public float speed = 200f;
	public Text uiText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.position += transform.forward * speed * Time.deltaTime;
			uiText.text = "I'm moving forward!";
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position -= transform.forward *  speed * Time.deltaTime;
			uiText.text = "I'm moving backwards!";
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0f, -30f  * Time.deltaTime, 0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0f, 30f  * Time.deltaTime, 0f);
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.position += transform.up * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			transform.position -= transform.up * speed * Time.deltaTime;
		}
	
	}
}
