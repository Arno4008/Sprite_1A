using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> inventory = new List<GameObject>();

    void Update()
    {
       
    }

    public void AddItem(GameObject item)
    {
        inventory.Add(item);
    }

   /* private void Drop()
    {
        if (inventory.Count == 4)
        {
            foreach (GameObject Collectible in inventory)
            {
                Collectible.transform.position = Pilier.transform.position;
                Collectible.SetActive(true);
            }
        }
    }*/
}
