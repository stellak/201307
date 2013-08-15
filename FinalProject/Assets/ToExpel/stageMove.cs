using UnityEngine;
using System.Collections;

public class stageMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time>5){
			transform.position+= new Vector3 (0f, 10f, 0f) * Time.deltaTime;
		}
	}
}

