using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // トリガーとの接触時に呼ばれるコールバック
    void OnCollisionEnter2D(Collision2D col)
    {
        // 接触対象はPlayerタグですか？
        if (col.gameObject.tag == "Player")
        {
            // 何らかの処理
            // このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }
    }
}
