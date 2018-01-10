using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneController : MonoBehaviour {

	public Transform from;
	public Transform to;

	public float targetAngle;
	private Vector3 currentAngle;

	public float speed;

	public enum Direction{
		Up,
		Down,
		Left,
		Right,
		Still
	}

	public bool canGoUp;
	public bool canGoDown;
	public bool canGoLeft;
	public bool canGoRight;

	public bool canMove;

	public Button up;
	public Button down;
	public Button left;
	public Button right;

	void Start(){
		currentAngle = transform.eulerAngles;
	}
	
	void Update () {

//		if (Input.GetKey(KeyCode.UpArrow)){
//			currentAngle = new Vector3(Mathf.LerpAngle(currentAngle.x, targetAngle, Time.deltaTime * 10), 0, 0);
//		}else if (Input.GetKey(KeyCode.DownArrow)){
//			currentAngle = new Vector3(Mathf.LerpAngle(currentAngle.x, -targetAngle, Time.deltaTime * 10), 0, 0);
//		}else if (Input.GetKey(KeyCode.LeftArrow)){
//			currentAngle = new Vector3(0, 0, Mathf.LerpAngle(currentAngle.z, targetAngle, Time.deltaTime * 10));
//		}else if (Input.GetKey(KeyCode.RightArrow)){
//			currentAngle = new Vector3(0, 0, Mathf.LerpAngle(currentAngle.z, -targetAngle, Time.deltaTime * 10));
//		}
			
		if (Input.GetKey(KeyCode.RightArrow)){
			currentAngle = new Vector3(Mathf.LerpAngle(currentAngle.x, targetAngle, Time.deltaTime * speed), 0, currentAngle.z);
		}

//		else{
//			currentAngle = new Vector3(Mathf.LerpAngle(currentAngle.x, targetAngle, Time.deltaTime * 10), 0, currentAngle.z);
//		} 

		if (Input.GetKey(KeyCode.LeftArrow)){
			currentAngle = new Vector3(Mathf.LerpAngle(currentAngle.x, -targetAngle, Time.deltaTime * speed), 0, currentAngle.z);
		} 
		if (Input.GetKey(KeyCode.UpArrow)){
			currentAngle = new Vector3(currentAngle.x, 0, Mathf.LerpAngle(currentAngle.z, targetAngle, Time.deltaTime * speed));
		} 
		if (Input.GetKey(KeyCode.DownArrow)){
			currentAngle = new Vector3(currentAngle.x, 0, Mathf.LerpAngle(currentAngle.z, -targetAngle, Time.deltaTime * speed));
		}

		if(!Input.anyKey){
			currentAngle = new Vector3(
				Mathf.LerpAngle(currentAngle.x, 0, Time.deltaTime * speed ),
				Mathf.LerpAngle(currentAngle.y, 0, Time.deltaTime * speed ),
				Mathf.LerpAngle(currentAngle.z, 0, Time.deltaTime * speed ));
		}

		transform.eulerAngles = currentAngle;
	}
}
