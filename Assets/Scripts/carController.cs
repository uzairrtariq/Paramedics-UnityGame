using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    public float carSpeed;
    public float maxPos = 9.7f;
    Vector3 position;

    public bool start;
    private bool loss;
    public int lives;
    public TextMesh textLives;
    public TextMesh textTime;
    public TextMesh textGameOver;
    public float timeLeft = 0f;

    // Start is called before the first frame update
    void Start()
    {
        start = false;
        loss = false;
        position = transform.position;
        lives = 5;
        Time.timeScale = 0;
        

    }

    void gameOver()
    {
        loss = true;
        textGameOver.text = "Game Over!";
        start = false;
        Time.timeScale = 0;
       


    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft == 0f && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("CarStart");
            Time.timeScale = 1;
            start = true; 
        }

        if (start)
        {
            position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
            position.x = Mathf.Clamp(position.x, -maxPos, maxPos);
            transform.position = position;

            timeLeft = timeLeft + Time.deltaTime;
            textTime.text = "Time: " + timeLeft;
        }

        if (loss)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("test");
                Application.LoadLevel("menuScene");
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {

            lives = lives - 1;
            //Destroy(col.gameObject);
            textLives.text = "Lives: " + lives.ToString();
            if (lives == 0) {
                gameOver();
            }
        }
    }
}
