using UnityEngine;
using System.Collections;

public class cubeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += new Vector3(0, 20f, 0)*Time.deltaTime;
		Debug.Log (Time.time);
	}
}


