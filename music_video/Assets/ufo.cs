using UnityEngine;
using System.Collections;

public class ufo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3( 700f, 300f, 900f ) * Mathf.Sin( Time.time );
       
	
	}
}
