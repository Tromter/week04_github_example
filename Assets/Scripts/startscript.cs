using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscript : MonoBehaviour {


	public GameObject sphere;

	private bool check;

	// Use this for initialization
	void Start () {
		check = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && check == false) {
			Instantiate (sphere, transform.position, Quaternion.identity);
			check = true;
		}
	}
}
