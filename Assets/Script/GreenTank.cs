using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTank : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow)) forward += 1;
        if (Input.GetKey(KeyCode.DownArrow)) forward -= 1;
        if (Input.GetKey(KeyCode.LeftArrow)) rotate += 1;
        if (Input.GetKey(KeyCode.RightArrow)) rotate -= 1;
        //float dis = forward * settings.speed * Time.deltaTime;
        //Vector3 from = transform.position + transform.up * 0.7f;
        //Vector3 to = from + transform.up * dis;
        //RaycastHit hit;
        //Debug.DrawLine(from, to, Color.black);
        //if (Physics.Linecast(from, to, out hit))
        //{
        //    Debug.Log("���У�");
        //    dis = (hit.point - from).magnitude;
        //}
        //transform.Translate(0, dis, 0);
        //rigidbody.velocity = transform.up * forward * settings.speed;
        //rigidbody.AddForce(transform.up * forward * settings.speed);
        transform.Translate(0, forward * settings.speed * Time.deltaTime, 0);
        transform.Rotate(0, 0, rotate * settings.rotspeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.M) && bulletNum < settings.bullets)
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