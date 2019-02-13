using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int lives;
    public bool start;
    public TextMesh textLives;
    public TextMesh textTime;
    public float timeLeft = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
        lives = 5;

        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = timeLeft + Time.deltaTime;
        textTime.text = "Time: " + timeLeft;


        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            lives = lives - 1;
            Destroy(collision.gameObject);
            textLives.text = "Lives: " + lives.ToString();
        };
    }
}
