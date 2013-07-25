using UnityEngine;
using System.Collections;

public class tenPrint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text +=  Random.value > 0.5f ? "/" : "||";
}
