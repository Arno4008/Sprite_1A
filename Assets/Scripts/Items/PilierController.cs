using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilierController : MonoBehaviour
{
    public GameObject DropZone;
    public bool isEmpty = true;
    public GameObject PressE;

    // Start is called before the first frame update
    void Start()
    {
        PressE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && isEmpty && other.gameObject.GetComponent<Inventory>().inventory.Count > 0)
        {
            // can press E to drop item
            other.gameObject.GetComponent<Player>().canDropItem = true;
            other.gameObject.GetComponent<Player>().DropZone = DropZone;
            PressE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // can press E to drop item
            other.gameObject.GetComponent<Player>().canDropItem = false;
            other.gameObject.GetComponent<Player>().DropZone = null;
            PressE.SetActive(false);
        }
    }
}
