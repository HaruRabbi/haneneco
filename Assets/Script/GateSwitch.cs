using UnityEngine;
using System.Collections;

public class GateSwitch : MonoBehaviour
{
    public Gateup gateup;
    public Sprite[] swichSprite; //0にデフォルト画像、１に変えたい画像を入れてね♡
    SpriteRenderer swichSp;


    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            gateup.Up();
            swichSp.sprite = swichSprite[1];
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
        swichSp.sprite = swichSprite[0];
    }

    // Use this for initialization
    void Start()
    {
        swichSp = GetComponent<SpriteRenderer>();
        swichSp.sprite = swichSprite[0];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
