using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void OnTriggerEnter(Collider knife) //aaa為自定義碰撞事件
    {    
        if (knife.gameObject.tag == "object") //如果aaa碰撞事件的物件標籤名稱是test
        {    
            Destroy(knife.gameObject); //刪除碰撞到的物件(CubeA)
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
