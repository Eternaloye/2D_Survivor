using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Player : MonoBehaviour
{
    private Transform target;   //跟随目标的transform组件
    private Vector3 distance;   //相机与玩家位置偏移量
    [SerializeField] private Vector2 limitXY = new Vector2(100,50);   //相机跟随范围
    void Start()
    {
        //通过玩家标签获取玩家的transform组件
        target=GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        //相机跟随目标
        distance = target.position;
        distance.z = -10;
        distance.x = Mathf.Clamp(distance.x, -limitXY.x, limitXY.x);
        distance.y = Mathf.Clamp(distance.y, -limitXY.y, limitXY.y);
        transform.position = distance;
    }
}
