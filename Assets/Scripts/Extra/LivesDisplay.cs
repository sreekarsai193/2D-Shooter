using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Health health;
    [SerializeField] Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        health=player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayLives();
    }
    private void DisplayLives()
    {
        livesText.text = "Lives:" + health.currentLives.ToString();
    }
}
