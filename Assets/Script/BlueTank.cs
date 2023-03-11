using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTank : MonoBehaviour
{
    private TankSettings settings;
    private int bulletNum = 0;
    private float radius = 2.2f;   // 鼠标移动的控制半径
    private void Start()
    {
        settings = GameObject.Find("TankSettings").GetComponent<TankSettings>();
    }
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector3 mouseLine = mousePos - transform.position;
        transform.Rotate(0, 0, Vector3.SignedAngle(mouseLine, transform.up, new Vector3(0, 0, -1)));
        if (mouseLine.magnitude > radius)
            transform.Translate(0, settings.speed * Time.deltaTime, 0);

        if (Input.GetMouseButtonDown(0) && bulletNum < settings.bullets)
        {
            bulletNum++;
            Shoot();
        }
    }
    void Shoot()
    {
        GetComponent<AudioSource>().Play();
        GameObject bullet = Instantiate(settings.bulletPrefab, transform.position + transform.up * 0.8f, transform.rotation);
        bullet.GetComponent<Bullet>().father = this.gameObject;
    }
    void AddBullet()
    {
        bulletNum--;
    }
    void Explode()
    {
        Instantiate(settings.explosionPrefab, transform.position, transform.rotation);
    }
}