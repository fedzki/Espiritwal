using UnityEngine;
using System.Collections;

public class randomInst : MonoBehaviour {

	public int randomNum;
	public Rigidbody[] arrowKeys;
	public float timer;
	public float keySpeed = 4.0f;
	public float interval = 2.5f;
	public int mod = 1;


	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {



		timer += 1.0f * Time.deltaTime;
		if (timer >= interval) {
			randomNum = (Random.Range (1, 5));
			timer = 0.0f;
			for (int i = 0; i <= randomNum; i++) {
				if(i == randomNum){
					Instantiate(arrowKeys[randomNum-1], this.transform.localPosition, this.transform.localRotation);
				
				}
			}

		}
	

	}
}
