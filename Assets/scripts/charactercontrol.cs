using UnityEngine;
using System.Collections;

public class charactercontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(Input.GetKeyDown(KeyCode.F)==true){
			Debug.Log("player pushed the F key!");
			transform.position = transform.position + new Vector3( 0f, 1f*Time.fixedDeltaTime, 0f );
	}
		
		if(Input.GetKeyDown( KeyCode.W)==true ){
		transform.position=transform.position + new Vector3(0f,5f,0f);
	}
	
			if(Input.GetKeyDown( KeyCode.S)==true ){
		transform.position=transform.position + new Vector3(0f,-5f,0f);
			
	}
			if(Input.GetKeyDown( KeyCode.A)==true ){
		transform.position=transform.position + new Vector3(5f,0f,0f);
			
	}
			if(Input.GetKeyDown( KeyCode.D)==true ){
		transform.position=transform.position + new Vector3(-5f,0f,0f);
		}		
}}
	