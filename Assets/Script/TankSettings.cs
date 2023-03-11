using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TankSettings : MonoBehaviour
{
    public float speed = 5.0f;          // 坦克移动速度
    public float rotspeed = 180;        // 坦克旋转速度
    public GameObject bulletPrefab;     // 子弹预制体
    public int bullets = 5;             // 可发射的子弹数
    public GameObject explosionPrefab;  // 爆炸效果
}
