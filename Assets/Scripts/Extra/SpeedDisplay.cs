using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour
{
    Controller controller;

    [SerializeField] Text speedText;
    // Start is called before the first frame update
    void Start()
    {
        controller=FindObjectOfType<Controller>();  
    }

    // Update is called once per frame
    void Update()
    {
        DisplayScore();
    }
    private void DisplayScore()
    {
        if (controller.moveSpeed<25f)
        {
            speedText.text = "Speed:" + System.Math.Round(controller.moveSpeed, 2).ToString();
        }
        else
        {
            speedText.text = "Speed:Max";
        }
       
    }
}
