using UnityEngine;
using System.Collections;

public class keyTriggers : MonoBehaviour {




	public bool Up;
	public bool Down;
	public bool Left;
	public bool Right;

	private summonLS currentLS;
	private summonLS hitKey;

	private randomInst Inter;
	public Animator anim;

	// Use this for initialization
	void Start () {
	
		currentLS = GameObject.Find ("lifeSpanTrigger").GetComponent<summonLS> ();
		hitKey = GameObject.Find ("lifeSpanTrigger").GetComponent<summonLS> ();
		Inter = GameObject.Find ("keys").GetComponent<randomInst> ();
		anim = GameObject.Find ("proto_babaylan 1").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		 
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (Up == true && other.tag == "Up") {
			hitKey.Combo ++;
			currentLS.lifeSpan += 1.0f;
			Destroy (other.gameObject);
			Debug.Log ("destroyU");
			anim.SetTrigger("triggerUp");

			if(Inter.mod == 0 && Inter.interval >= 0.5f && Inter.keySpeed <= 12.0f){
				Inter.interval -= 0.5f;
				Inter.keySpeed += 2.0f;
				Debug.Log("++ interval");
			}
		
		}
		if (Down == true && other.tag == "Down") {
			hitKey.Combo ++;
			currentLS.lifeSpan += 1.0f;
			Destroy (other.gameObject);
			Debug.Log ("destroyD");
			anim.SetTrigger("triggerDown");
			if(Inter.mod == 0 && Inter.interval >= 0.5f && Inter.keySpeed <= 12.0f){
				Inter.interval -= 0.5f;
				Inter.keySpeed += 2.0f;
				Debug.Log("++ interval");

			}
			
		}
		if (Left == true && other.tag == "Left") {
			hitKey.Combo ++;
			currentLS.lifeSpan += 1.0f;
			Destroy (other.gameObject);
			Debug.Log ("destroyL");
			anim.SetTrigger("triggerLeft");
			if(Inter.mod == 0 && Inter.interval >= 0.5f && Inter.keySpeed <= 12.0f){
				Inter.interval -= 0.5f;
				Inter.keySpeed += 2.0f;
				Debug.Log("++ interval");
			}
			
		}
		if (Right == true && other.tag == "Right") {
			hitKey.Combo ++;
			currentLS.lifeSpan += 1.0f;
			Destroy (other.gameObject);
			Debug.Log ("destroyR");
			anim.SetTrigger("triggerRight");
			if(Inter.mod == 0 && Inter.interval >= 0.5f && Inter.keySpeed <= 12.0f){
				Inter.interval -= 0.5f;
				Inter.keySpeed += 2.0f;
				Debug.Log("++ interval");

			}
			
		}
		if (Up == true && other.tag != "Up") {
			currentLS.lifeSpan -= 5.0f;
			hitKey.Combo = 0;
			Debug.Log ("miss");		
		
		}
		if (Down == true && other.tag != "Down") {
			currentLS.lifeSpan -= 5.0f;
			hitKey.Combo = 0;
			Debug.Log ("miss");		
			
		}
		if (Left == true && other.tag != "Left") {
			currentLS.lifeSpan -= 5.0f;
			hitKey.Combo = 0;
			Debug.Log ("miss");		
			
		}
		if (Right == true && other.tag != "Right") {
			currentLS.lifeSpan -= 5.0f;
			hitKey.Combo = 0;
			Debug.Log ("miss");		
			
		}
	}

}




