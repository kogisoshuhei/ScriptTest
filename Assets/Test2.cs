using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic {
	
	private int mp = 53; // MP

	//
	public void Decrease(int decrease) {

		for (int i = 1; i <= 11; i++){

			if (mp >= decrease) {

				this.mp -= decrease;

				Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");

			} else {
			
				Debug.Log ("MPが足りないため魔法が使えない。");

			}

		}
		
	}

}

public class Test2 : MonoBehaviour {

	void Start () {
		
		// Magicクラスの変数を宣言してインスタンスを代入
		Magic decreasePt = new Magic ();

		// 魔法消費用の関数を呼び出す
		decreasePt.Decrease( 5 );
	
	}

}