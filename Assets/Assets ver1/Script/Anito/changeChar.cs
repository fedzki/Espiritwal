using UnityEngine;
using System.Collections;

public class changeChar : MonoBehaviour {
	public GameObject anitoN;
	public GameObject anitoS;
	public GameObject anitoEW;
	public bool turned;
	public bool left;
	public bool right;
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
			anitoN.SetActive(true);
			anitoS.SetActive(false);
			anitoEW.SetActive(false);
			turned = false;
		}else if(Input.GetKey("s")){
			anitoN.SetActive(false);
			anitoS.SetActive(true);
			anitoEW.SetActive(false);
			turned = false;
		}else if(Input.GetKey("d")){
			anitoN.SetActive(false);
			anitoS.SetActive(false);
			anitoEW.SetActive(true);
			left = false;
			right = true;
			if(Input.GetKey("d") && left == false && turned == true ){
				anitoEW.transform.localScale= new Vector2 (anitoEW.transform.localScale.x * -1.0f, anitoEW.transform.localScale.y);
				turned = false;

			}
		}else if(Input.GetKey("a")){
			anitoN.SetActive(false);
			anitoS.SetActive(false);
			anitoEW.SetActive(true);
			left = true;
			right = false;
				if(Input.GetKey("a") && right == false && turned == false ){
				anitoEW.transform.localScale= new Vector2 (anitoEW.transform.localScale.x * -1.0f, anitoEW.transform.localScale.y);
				turned = true;
			}
		}
	}

}
