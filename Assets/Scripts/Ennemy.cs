using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public int EnnemyLife = 3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ennemy"))
        {
            EnnemyLife--;

        }
    }
    public void TakeDamage(int amount)
    {
        EnnemyLife -= amount;

        if (EnnemyLife <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
