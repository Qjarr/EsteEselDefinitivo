using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);

         string time = string.Format("{0:0}:{1:00}", minutes, seconds);
        //string time = minutes + ":" + seconds;

        //timerText.text = ((int)timer).ToString();
        timerText.text = time;
        
    }
}
