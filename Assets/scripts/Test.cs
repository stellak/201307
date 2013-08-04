using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	
	int Power = 500;
	
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {}

	void FixedUpdate(){
	
		if (Input.GetKeyDown (KeyCode.Space)== true)
		rigidbody.AddForce (Vector3.forward*Power);
	}
}
