using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{
    public float speed;             //�ƶ��ٶ�
    private Rigidbody2D rig;        //�������
    private Vector2 direction;      //�ƶ�����
    float moveX;                    //ˮƽ��������
    float moveY;                    //��ֱ��������
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //��ȡˮƽ����ֱ���������
        moveX = Input.GetAxisRaw("Horizontal"); 
        moveY = Input.GetAxisRaw("Vertical");   
        // ������ֵ�洢��movement������
        direction = new Vector2(moveX, moveY).normalized; 
    }
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + direction * speed * Time.fixedDeltaTime);
    }
}
