using UnityEngine;
using System.Collections;

public class GateSwitch : MonoBehaviour
{
    public Gateup gateup;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            gateup.Up();
        }
    }

    public void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Invoke("InvokeDown", 5.0f);
        }
    }

    public void InvokeDown()
    {
        gateup.Down();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
