using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private AudioSource audioSource;// AudioSorceコンポーネント格納用
    public AudioClip sound;// 効果音の格納用。インスペクタで。

    // Use this for initialization
    void Start ()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.loop = false;
        audioSource.PlayOneShot(sound);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.R))
        {
            // 現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            // 現在のシーンを再読込する
            SceneManager.LoadScene(sceneIndex);
        }
	}
    
}
