using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ennemy : MonoBehaviour
{
    public int EnnemyLife = 3;
    public float range = 10.0f;

    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        for (int i = 0; i < 30; i++)
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range;
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
            {
                result = hit.position;
                return true;
            }
        }
        result = Vector3.zero;
        return false;
    }

    private void Start()
    {
    }

    private void Update()
    {
        if(GetComponent<NavMeshAgent>().velocity == Vector3.zero)
        {
            Vector3 newPosition;
            if (RandomPoint(transform.position, range, out newPosition))
            {
                GetComponent<NavMeshAgent>().SetDestination(newPosition);
            }
            else
            {
                Debug.LogWarning("Position not found");
            }
        }
    }


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
