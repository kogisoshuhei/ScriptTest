using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start(){

		//課題１
		int[] array = { 30, 20, 60, 80, 10 };

		Debug.Log ( "昇順" );

		for (int i = 0; i <= 4; i++) {

			Debug.Log ( array [i] );

		}

		Debug.Log ( "逆順" );

		for (int i = 4; i >= 0; i--) {
		
			Debug.Log ( array [i] );
		
		}

	}

}