﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelect : MonoBehaviour
{
    private AudioSource audioSource;// AudioSorceコンポーネント格納用
    public AudioClip sound;// 効果音の格納用。インスペクタで。

    //public int minite = 0;
    //public float second = 0;
    //public Text textField;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.loop = false;
        audioSource.PlayOneShot(sound);

        if (Time.timeScale > 0)
        {
            //second += Time.deltaTime;

            //if (second > 60.0f)
            //{
            //    minite++;
            //    second = 0;
            //}
            //second = Mathf.Floor(0.5f);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            SceneManager.LoadScene("Fade-in");
        }
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Main2");
        }

        //textField.text = "タイム：" + minite + "分" + second.ToString("f0") + "秒";
    }    
}
