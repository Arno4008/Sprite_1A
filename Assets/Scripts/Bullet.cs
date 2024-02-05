using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    private int damage = 0; 

    void Awake()
    {
        Destroy(gameObject, life);
    }


    public void SetDamage(int amount)
    {
        damage = amount;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ennemy"))
        {
            collision.gameObject.GetComponent<Ennemy>().TakeDamage(damage); 
        }

        Destroy(gameObject); 
    }
}