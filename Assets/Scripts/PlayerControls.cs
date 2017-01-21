using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public GameObject rightBlaster;
	public GameObject leftBlaster;
	public GameObject shield;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			leftBlaster.SetActive (true);
		} else {
			leftBlaster.SetActive (false);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rightBlaster.SetActive (true);
		} else {
			rightBlaster.SetActive (false);
		}

		if (Input.GetKey (KeyCode.Space)) {
			shield.SetActive (true);
		} else {
			shield.SetActive (false);
		}
	}
}
