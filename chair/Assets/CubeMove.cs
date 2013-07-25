using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {
	
	float lastTimeCubeMoved= 0f ;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.position = transform.position + new Vector3( 0f, 0f, 1f * Time.deltaTime);
		transform.position += new Vector3( 0f, 0f, 1f) * Time.deltaTime;
		
		Debug.Log( Time.time );
		
		if ( Time.time > lastTimeCubeMoved + 3f) {
			lastTimeCubeMoved = Time.time;
			Transform.position += new Vector3 ( 0f, 0f, 3f);
	}
		
		transform.position = new Vector3( 0f, 5f, 0f ) * Mathf.Sin ( Time.time);
		transform.localScale = new Vector3 ( 1f, 2f, 1f ) * Mathf.Sin(Time.time);
		
		Debug.Log( Time.time ); 
	}
}
