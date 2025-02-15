using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{
    public float speed;             //移动速度
    private Rigidbody2D rig;        //刚体组件
    private Vector2 direction;      //移动方向
    float moveX;                    //水平方向输入
    float moveY;                    //竖直方向输入
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //获取水平和竖直方向的输入
        moveX = Input.GetAxisRaw("Horizontal"); 
        moveY = Input.GetAxisRaw("Vertical");   
        // 将输入值存储到movement变量中
        direction = new Vector2(moveX, moveY).normalized; 
    }
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + direction * speed * Time.fixedDeltaTime);
    }
}
