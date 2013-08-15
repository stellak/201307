using UnityEngine;
using System.Collections;

public class mosquitoScream : MonoBehaviour {
	public GameObject mosquito;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void OnMouseUp(){
		audio.Play();
	}
}