using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Player : MonoBehaviour
{
    private Transform target;   //����Ŀ���transform���
    private Vector3 distance;   //��������λ��ƫ����
    [SerializeField] private Vector2 limitXY = new Vector2(100,50);   //������淶Χ
    void Start()
    {
        //ͨ����ұ�ǩ��ȡ��ҵ�transform���
        target=GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        //�������Ŀ��
        distance = target.position;
        distance.z = -10;
        distance.x = Mathf.Clamp(distance.x, -limitXY.x, limitXY.x);
        distance.y = Mathf.Clamp(distance.y, -limitXY.y, limitXY.y);
        transform.position = distance;
    }
}
