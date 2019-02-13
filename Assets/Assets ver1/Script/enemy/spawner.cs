using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public GameObject enemy;
	public int randPos;
	public GameObject[] spawnPoint;
	public bool inst;
	public int randPt;
	public int randNE;
	public float cdInst;
	public float intervalNE;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		randNE = (Random.Range (1, 4));
		randPt = (Random.Range (1, 5));
		randPos = (Random.Range (5, 10));

		if (inst == false) {
			cdInst += 1.0f * Time.deltaTime;
			if (cdInst >= intervalNE){
				cdInst = 0.0f;
				inst = true;
			}
		
		}

		if (inst == true) {
		
			Inst();
			inst = false;
		
		}

	}

	void Inst(){
		Instantiate (enemy, spawnPoint[randPt-1].transform.position, spawnPoint[randPt-1].transform.rotation);
	}

}
