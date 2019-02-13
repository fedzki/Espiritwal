using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cTxt : MonoBehaviour {


		public Text text;
		private summonLS cText;
		
		// Use this for initialization
		void Start () {
			
			cText = GameObject.Find("lifeSpanTrigger").GetComponent<summonLS>();
			text = this.gameObject.GetComponent<Text>();
		}
		
		// Update is called once per frame
		void Update () {
			
			text.text = "" + cText.Combo;
			
		}
		
		
	}
