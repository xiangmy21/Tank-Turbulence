using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTank : MonoBehaviour
{
    private TankSettings settings;
    private int bulletNum = 0;
    private AudioSource audioShoot;
    private void Start()
    {
        settings = GameObject.Find("TankSettings").GetComponent<TankSettings>();
        audioShoot = GetComponent<AudioSource>();
    }
    void Update()
    {
        float forward = 0, rotate = 0;
        if (Input.GetKey(KeyCode.E)) forward += 1;
        if (Input.GetKey(KeyCode.D)) forward -= 1;
        if (Input.GetKey(KeyCode.S)) rotate += 1;
        if (Input.GetKey(KeyCode.F)) rotate -= 1;
        transform.Translate(0, forward * settings.speed * Time.deltaTime, 0);
        transform.Rotate(0, 0, rotate * settings.rotspeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Q) && bulletNum < settings.bullets)
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