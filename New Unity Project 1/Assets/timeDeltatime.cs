using UnityEngine;
using System.Collections;

public class timeDeltatime : MonoBehaviour 
{
	public float speed = 8f;
	public float countdown = 3f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		countdown -= Time.deltaTime;
		if(countdown<=0.0f)
			transform.position+= new Vector3 (0,5*Time.deltaTime,0);
		if(Input.GetKey(KeyCode.RightArrow))
			transform.position+=new Vector3(speed*Time.deltaTime,0.0f,0.0f);
	
	}
}
