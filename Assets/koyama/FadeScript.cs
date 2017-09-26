﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    public float speed = 0.01f;  //透明化の速さ
    float alfa = 1.0f;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数

    // Use this for initialization
    void Start()
    {
        //Panelの色を取得
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().color = new Color(red, green, blue, alfa);
        alfa -= speed;

        if (alfa == 0.0f)
        {
            //renderer.enabled = false;
        }
    }
}