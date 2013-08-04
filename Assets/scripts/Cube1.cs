using UnityEngine;
using System.Collections;

public class Cube1 : MonoBehaviour {
	
	public string cubename = "firstCube";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGui (){
		GUILayout.Label("CubeName is ", cubename);
	}
}
