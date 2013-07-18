using UnityEngine;
using System.Collections;

public class hoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void onTriggerEnter() //happens when something enters the trigger
	{Light.enabled=false;
		
	}
}
