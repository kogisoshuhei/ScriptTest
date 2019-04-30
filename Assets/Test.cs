using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start () {

		//通常課題
		int[] array = { 30, 20, 60, 80, 10 };

		Debug.Log ( "昇順" );

		for (int i = 0; i <= 4; i++) {

			Debug.Log ( array [i] );

		}

		Debug.Log ( "逆順" );

		for (int i = 4; i >= 0; i--) {

			Debug.Log ( array [i] );

		}

		//発展課題
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss decreasePt = new Boss ();

		// 魔法消費用の関数を呼び出す
		decreasePt.Magic( 5 );

	
	}

	public class Boss {

		private int mp = 53; // MP

		//
		public void Magic(int decrease) {

			for (int i = 0; i <= 10; i++){

				if (mp >= decrease) {

					this.mp -= decrease;

					Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");

				} else {

					Debug.Log ("MPが足りないため魔法が使えない。");

				}

			}

		}

	}

}