using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liftcontroller : MonoBehaviour
{
    Animator anima;

    // Use this for initialization
    void Start ()
    {
        //anima = GetComponent<Animator>;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //オブジェクトが触れている間
    void OnCollisionStay2D(Collision collision)
    {

    }
}
