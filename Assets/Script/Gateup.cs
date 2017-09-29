using UnityEngine;
using System.Collections;

public class Gateup : MonoBehaviour {

    Vector2 startPosition;
	
    // Use this for initialization
	void Start ()
    {
        startPosition = transform.position;    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// 扉を上げる
    /// </summary>
    public void Up()
    {
        transform.position = startPosition+new Vector2(0,12);
    }

    public void Down()
    {
        transform.position = startPosition;
    }
}
