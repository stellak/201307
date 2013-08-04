using UnityEngine;
using System.Collections;

public class fishmove : MonoBehaviour {

	public Vector3 destination;
	float roamRange = 25f;
	
	
	// Use this for initialization
	void Start () {
		//this one is to repeatedly execute "SetNewDestination", after an initial delay of 0 seconds, every
		InvokeRepeating("SetNewDestination",0f,15f);//start doing it immediately(0f), how often invoke it(15f)
		//anytime never put loop inside of loop is very dangerous
		//when we want to test the number value and how it affects, double the value or halve the value. 
		
	}
	
	void Update(){
		transform.rotation = Quaternion.LookRotation(rigidbody.velocity);	
		//the fish always face the direction it's moving. Robert made this because fish moved rotation....
		
		
		
	}
	// Update is called every physics frame
	void FixedUpdate () {
		//we use vector subtraction to move the fish
		//rigidbody.AddForce(destination - transform.position, ForceMode.VelocityChange);
		//(100,0,0)-(0,0,0) vs (1000,0,0)-(0,0,0)...fish 엄청 빨리 움직인다. 이걸 노멀라이즈해줘야됨
		//ddiving a vector by its magnitude 를 해줌. 
		//timedeltatime no need here
		rigidbody.AddForce(Vector3.Normalize(destination-transform.position)*0.5F, ForceMode.VelocityChange);
		//0.5F는 속도그 반으로 줄인다는거다
		
	void SetNewDestination(){
		
			destination=Random.insideUnitSphere*roamRange;
	}
	public void SetNewDestination(Vector3,newDestination){
		Audio.Play();
		destination=newDestination;
	}
}


//what is NPC? MPC? (fish 이야기할때 했던...)