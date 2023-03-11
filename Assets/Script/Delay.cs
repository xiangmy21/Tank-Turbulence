using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    private float birth;
    private float lifetime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        birth = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - birth > lifetime)
            Destroy(gameObject);
    }
}
