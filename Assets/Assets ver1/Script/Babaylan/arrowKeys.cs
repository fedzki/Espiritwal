using UnityEngine;
using System.Collections;

public class arrowKeys : MonoBehaviour {



	public GameObject upTrigger;
	public GameObject downTrigger;
	public GameObject leftTrigger;
	public GameObject rightTrigger;

	public bool isPress = false;
	public int Timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isPress == true){
			Timer ++;
		
			if (Timer >= 10){
				upTrigger.SetActive(false);
				downTrigger.SetActive(false);
				leftTrigger.SetActive(false);
				rightTrigger.SetActive(false);
				isPress = false;
				Timer = 0;

			}
		}

		if (Input.GetKeyDown(KeyCode.UpArrow)){
			 
			upTrigger.SetActive(true);
			isPress = true;

		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			
			downTrigger.SetActive(true);
			isPress = true;
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow)){
			
			leftTrigger.SetActive(true);
			isPress = true;
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow)){
			
			rightTrigger.SetActive(true);
			isPress = true;
		}

	}
}
