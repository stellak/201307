using UnityEngine;
using System.Collections;
using System.Collections.Generic;//이 라인이 없으면 리스트를 쓸 수 없다. 리스트는 뭐에 유용하하냐면, array (a bunch of different compartment to keep 
//things. here it's bunch of fish. To each box which is array, which has number, the first box number is 0 (zero).
//array is immutable (if you want to change the array, you have to make the whole new array just to resize it. Whish is annoying. in C#, therefore,
//they made the 'list', which is dynamic and resizable. It's special form of array. 


public class fishGod : MonoBehaviour {

	public fish fishBlueprint;
	public List<Fish> fishList =
	
	// Use this for initialization
	void Start () {
		//spawning을 우ㅐ해서는 instantiante를 쓴다. 이걸 위해 위에서 피쉬블루프린트를 선언해주고
		//블루프린트를 프고젝트에 프리팸으로 만들어준다. 
		//프로젝트탭에서 물건을 끌어다가 써라. 신탭에서 끌어ㅓ다 쓰지말고. 
		int counter =0;
		while (counter <100){
			//generate random coordinates inside one unit of sphere) 
			//quater...는 000point에서 spawning아락ㄴ거다. 25사이즈의 스피어 내에서) 
		Fish newFish = Instantiate(fishBlueprint, Random.insideUnitSphere*25f,Quaternion.identity)as Fish;
		fishList.Add(newFish);
		counter ++;
	}
	
	// Update is called once per frame

	
	void Update() {
			
}
