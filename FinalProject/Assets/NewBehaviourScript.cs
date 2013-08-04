using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject MosquitoStage;
	public Transform UpPosition;
	public Transform DownPosition;
	
	public enum MosquitoStageStatus
	{
		Up,
		MovingUp,
		Selected,
		MovingDown,
		Down
	}
	
	public MosquitoStageStatus ControlState = MosquitoStageStatus.Up;
	
	float VentingTime = 0;
	bool venting = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ProcessCoreState();
	}
	
	void OnMouseUp()
	{
				switch (ControlState)
		{
		case MosquitoStageStatus.Up:
			ControlState = MosquitoStageStatus.MovingDown;
			if (venting)
			{
				venting = false;
				VentingTime = 0;
			}
			break;
			case MosquitoStageStatus.MovingUp:
			ControlState = MosquitoStageStatus.MovingDown;
			if (venting)
			{
				venting = false;
				VentingTime = 0;
			}
			break;
		default:
			break;
		}

	}
	void OnEnable()
	{
		
	}
	
	void OnDisable()
	{
		
	}
	
	
	void ProcessCoreState()
	{
		switch(ControlState)
		{
		case MosquitoStageStatus.Up:
			if (venting)
			{
				VentingTime += Time.deltaTime;
			
				if (VentingTime >= 2.0f)
				{
					venting = false;
			
				
				}
			}
			break;
			
		case MosquitoStageStatus.MovingDown:
			if (!MosquitoStage.transform.localPosition.Equals(DownPosition.localPosition))
			{
				MosquitoStage.transform.localPosition = Vector3.Lerp (MosquitoStage.transform.localPosition, DownPosition.localPosition, Time.deltaTime);
				float distance = Vector3.Distance(MosquitoStage.transform.localPosition, DownPosition.localPosition);
				if (distance <= 0.025f)
				{
					MosquitoStage.transform.localPosition = DownPosition.localPosition;
					MosquitoStage.transform.localPosition = new Vector3(DownPosition.localPosition.x, DownPosition.localPosition.y, DownPosition.localPosition.z);
				}
				
			}
			else
			{
				ControlState = MosquitoStageStatus.Down;
			}
			break;
			
		case MosquitoStageStatus.Selected:
			ControlState = MosquitoStageStatus.MovingUp;
			MosquitoStage.transform.localPosition = Vector3.Lerp (MosquitoStage.transform.localPosition, UpPosition.localPosition, Time.deltaTime);
			break;
			
		case MosquitoStageStatus.MovingUp:
			if (!MosquitoStage.transform.localPosition.Equals(UpPosition.localPosition))
			{
				MosquitoStage.transform.localPosition = Vector3.Lerp (MosquitoStage.transform.localPosition, UpPosition.localPosition, Time.deltaTime);
				float distance = Vector3.Distance(MosquitoStage.transform.localPosition, UpPosition.localPosition);
				if (distance <= 0.025f)
				{
					MosquitoStage.transform.localPosition = UpPosition.localPosition;
					MosquitoStage.transform.localPosition = new Vector3(UpPosition.localPosition.x, UpPosition.localPosition.y, UpPosition.localPosition.z);
				}
			}
			else
			{
				ControlState = MosquitoStageStatus.Up;
				Debug.Log ("Rod is up");
				venting = true;
			}
			break;
			
		default:
			break;
		}
	
	}
}
