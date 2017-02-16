using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class uiscript : MonoBehaviour {

	string myText;
	public GameObject clip;

	// Use this for initialization
	void Start () {
		myText = "Press Space to Begin!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
		{
			myText = "";
		}
	}

	void OnGUI(){
		GUI.Label (new Rect (150f, 150f, 600f, 300f), myText);
	}
		
	void OnTriggerEnter (Collider other){
		myText = "THE END";
		Instantiate (clip, transform.position, Quaternion.identity);
	}
}
