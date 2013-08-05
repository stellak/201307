using UnityEngine;
using System.Collections;

public class AudioTrigger : MonoBehaviour {
	public GameObject MosquitoStage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	
	void OnMouseUp(){
		audio.Play();
	}
}