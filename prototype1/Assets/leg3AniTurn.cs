using UnityEngine;
using System.Collections;

public class leg3AniTurn: MonoBehaviour {
	public GameObject other;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.Space))
		{animation.Play();
		}
		
}
	}