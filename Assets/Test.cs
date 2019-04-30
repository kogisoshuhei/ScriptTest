using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public class Boss {

		// 現在のMP
		private int mp = 53; 

		// Magic関数処理
		public void Magic(int decrease) {

			//mp量が消費mpより上かどうか
			if (mp >= decrease) {

				//消費mp分マイナスする
				this.mp -= decrease;

				Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
			
			//mp量が消費mpよりも下
			} else {

				Debug.Log ("MPが足りないため魔法が使えない。");

			}

		}

	}

	void Start () {


		//通常課題
		int[] array = { 30, 20, 60, 80, 10 };

		Debug.Log ( "昇順" );

		for (int i = 0; i <= 4; i++) {

			Debug.Log ( array [i] );

		}

		Debug.Log ( "降順" );

		for (int i = 4; i >= 0; i--) {

			Debug.Log ( array [i] );

		}


		//発展課題
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss decreasePt = new Boss ();

		// 魔法消費用の関数を10回＋1回呼び出す
		for (int i = 1; i <= 11; i++) {

			Debug.Log ( "MP消費：" + i + "回目");

			//消費MP量
			decreasePt.Magic (5);

		}

	}

}