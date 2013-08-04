using UnityEngine;
using System.Collections;

public class turnLight : MonoBehaviour {
	public GameObject other;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void OnCollisionEnter(Collision coll) {
		audio.Play();
		light.enabled = true;
}
	}