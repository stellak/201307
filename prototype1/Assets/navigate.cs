using UnityEngine;
using System.Collections;

public class navigate : MonoBehaviour {
	public float speed= 1.0F;
	public float power = 10F;
	public float rotationSpeed = 10.0F;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal")*rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0,0,translation);
		transform.Rotate(0,rotation,0);
		
	
	}
}
