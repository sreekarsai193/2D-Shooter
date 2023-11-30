using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]float fireRateDecrease = 0.1f;
    [SerializeField] GameObject player;
     ShootingController shootingcontroller=null;
    // Start is called before the first frame update
    void Start()
    {
        shootingcontroller =player.GetComponent<ShootingController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            if (shootingcontroller != null)
            {
              
                shootingcontroller.fireRate = shootingcontroller.fireRate - fireRateDecrease;
                Destroy(gameObject);
            }
            else
            {
               
            }
          
        }
    }
}
