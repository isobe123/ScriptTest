using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test:MonoBehaviour{

	void Start (){
		int[] array = { 5, 10, 15, 20, 25 };

		for (int a = 0; a < array.Length; a++) {
			Debug.Log (array [a]);
		}
		for (int b = 4; b >= 0; b--) {
			Debug.Log (array [b]);
		}



	Boss lastboss = new Boss ();
		for (int i = 0; i < 11; i++) {
			lastboss.Majic (5);
		}
	}


	public class Boss{
		private int mp = 53;

		public void Majic(int mpc){
		if (mp >= 5) {
				Debug.Log ("魔法攻撃をした。残りMPは" +( this.mp-mpc ) + "。");
				this.mp -= mpc;
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}

		}
	}


	// Update is called once per frame
	void Update () {		
	}
}