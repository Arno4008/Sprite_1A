using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float detectionDistance = 2.0f;
    public GameObject player;

    private bool isCollected = false;

    private void Update()
    {
        if (!isCollected)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

            if (distanceToPlayer <= detectionDistance && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Collect();
            }
        }
    }

    private void Collect()
    {
        isCollected = true;
        gameObject.SetActive(false);
        player.GetComponent<Inventory>().AddItem(gameObject);
    }
}
