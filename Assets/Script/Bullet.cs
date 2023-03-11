using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 6f;
    public float lifeTime = 15;
    private float birth;
    public GameObject father;
    public AudioClip audioVanish;
    // Start is called before the first frame update
    void Start()
    {
        birth = Time.time;
        //设置子弹的初始速度
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - birth > lifeTime)
        {
            if(father != null)
                father.SendMessage("AddBullet");
            AudioSource.PlayClipAtPoint(audioVanish, new Vector3(0, 0, -10));
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(father != null)
                father.SendMessage("AddBullet");
            collision.gameObject.SendMessage("Explode");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
