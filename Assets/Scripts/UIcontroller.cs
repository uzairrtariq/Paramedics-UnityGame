using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroller : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pause();
        }
    }

    public void Play()
    {
        Debug.Log("click");
        Application.LoadLevel("Firetrucks");
    }

    public void Pause()
    {
        Debug.Log(Time.timeScale);
        if (Time.timeScale == 1)
        {
            Debug.Log("Stopping");
            Time.timeScale = 0;
            Debug.Log(Time.timeScale);
        }
        else if (Time.timeScale == 0)
        {
            Debug.Log("Starting");
            Time.timeScale = 1;
        }
    }
}
