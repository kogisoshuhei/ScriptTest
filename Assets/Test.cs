using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic {        
	private int mp = 53; // 魔力

	// 魔法攻撃用の関数
	public void Attack(int decrease) {

		//残り魔力
		Debug.Log ("現在のMPは" + mp + "。");

		//魔力の消費をカウント
		for (int i = mp ; i > decrease ; i -= decrease ) {

			// 残りmpを減らす
			this.mp -= decrease;

			//魔法攻撃結果
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");

		}
		//mpが足りない
		Debug.Log ("MPが足りないため魔法が使えない。");
	}

}

public class Test : MonoBehaviour {

	void Start(){

		//課題１
		/*
		int[] array = { 1, 2, 3, 4, 5, 6 };

		for (int i = 5; i >= 0; i--) {

			Debug.Log ( array [i] );
		*/

		// Magicクラスの変数を宣言してインスタンスを代入
		Magic decreasePt = new Magic ();

		// 消費用の関数を呼び出し、消費MPを指定
		decreasePt.Attack( 5 );

	}
				
}