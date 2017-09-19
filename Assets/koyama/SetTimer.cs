using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour
{
    public int minite = 0;
    public float second = 0;
    //private int oldSecond = 0;
    public Text textField;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Time.timeScale > 0)
        {
            second += Time.deltaTime;
            
            if (second > 60.0f)
            {
                minite++;
                second = 0;
            }
            //second = Mathf.Floor(0.5f);
            textField.text = "タイム：" + minite + "分" + second.ToString("f0") + "秒";      
        }
	}
}
