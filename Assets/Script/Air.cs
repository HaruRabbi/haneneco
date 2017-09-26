﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : MonoBehaviour
{
    public GameObject spawnObject;
    //発生間隔用
    public float interval = 3.0f;
   
    // Use this for initialization
    void Start()
    {
        //コルーチンの開始
        StartCoroutine("Spawn");
    }
    IEnumerator Spawn()
    {
        //無限ループの開始
        while (true)
        {
            //自分をつけたオブジェクトの位置に、発生するオブジェクトをインスタンス化して生成する
            Instantiate(spawnObject, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
