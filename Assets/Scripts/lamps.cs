using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamps : MonoBehaviour
{
    public GameObject lamp;
    public float maxPos = 12f;
    public float delayTimer = 1.5f;
    float timer;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 leftLamp = new Vector3(-maxPos, transform.position.y, transform.position.z);
            Vector3 rightLamp = new Vector3(maxPos, transform.position.y, transform.position.z);
            Instantiate(lamp, leftLamp, transform.rotation);
            Instantiate(lamp, rightLamp, transform.rotation);
            timer = delayTimer;
        }

     
    }
}