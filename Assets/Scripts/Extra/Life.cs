using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] GameObject player;
    Health health;
    // Start is called before the first frame update
    void Start()
    {
        health = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            health.currentLives++;
            Destroy(gameObject);
        }
    }
}
