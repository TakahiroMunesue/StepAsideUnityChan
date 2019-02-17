using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDestroyer : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとアイテムの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        if(this.difference > 5.0f)
        {
            Destroy(this.gameObject);
        }

    }
}
