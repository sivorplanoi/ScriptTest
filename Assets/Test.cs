using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	// mp を53で初期化
	private int mp = 53;

	public void Magic() {
			// mpが5以上の時魔法攻撃、5未満の時魔法が使えない
			if (mp >= 5) {
				mp -= 5;
				Debug.Log ("魔法攻撃をした。残りMPは" + mp);
			} else {
				Debug.Log("MPが足りないため魔法が使えない。");
			}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
			// 配列初期化
			int[] array = { 1, 2, 3, 4, 5 };

			// 順表示
			Debug.Log ("↓配列順表示");
			for (int i = 0; i < array.Length; i++) {
				Debug.Log (array [i]);
			}
			// 逆順表示
			Debug.Log ("↓配列逆順表示");
			for (int i = array.Length - 1; i >= 0; i--) {
				Debug.Log (array [i]);
			}

			// Bossクラスのインスタンス作成
			Boss boss = new Boss ();

			// 11回魔法攻撃
			for (int i = 1; i <= 11; i++) {
				boss.Magic ();
			}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
