using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Presets;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float detectionDistance = 2.0f;
    public GameObject player;
    public GameObject PressE;

    private bool isCollected = false;
    void Start()
    {
        PressE.SetActive(false);
    }
    private void Update()
    {
        if (!isCollected)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

            if (distanceToPlayer <= detectionDistance && Input.GetKeyDown(KeyCode.E))
            {
                Collect();
            }
        }
    }

    private void Collect()
    {
        isCollected = true;
        gameObject.SetActive(false);
        PressE.SetActive(false);
        player.GetComponent<Inventory>().AddItem(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            PressE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            PressE.SetActive(false);
        }
    }
}
