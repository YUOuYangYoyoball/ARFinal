using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject targetObject; //用來代表控制的遊戲物件
    public float speed = 0.001f; //控制物件的前進速度
    public float rotationSpeed = 100.0f;
    private bool isForward = false, isBackward = false, isTurnLeft = false, isTurnRight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //targetObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
             
        if (isTurnLeft) targetObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (isTurnRight) targetObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    
    }
    public void TurnLeftButtonDown() { //左轉按鈕被按下時的事件處理函數
        isTurnLeft = true;
    }
    public void TurnLeftButtonUp() { //左轉按鈕被放開時的事件處理函數
        isTurnLeft = false;
    }
    public void TurnRightButtonDown() { //右轉按鈕被按下時的事件處理函數
        isTurnRight = true;
    }
    public void TurnRightButtonUp() { //右轉按鈕被放開時的事件處理函數
        isTurnRight = false;
    }
}
