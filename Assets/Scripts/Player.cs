using EmeraldAI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canDropItem = false;
    public Inventory Inventory;
    public GameObject DropZone;

    void Update()
    {
        if (canDropItem)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Inventory.inventory.Count > 0)
                {
                    GameObject itemToDrop = Inventory.inventory[0];
                    itemToDrop.SetActive(true);
                    itemToDrop.transform.position = DropZone.transform.position;
                    DropZone.GetComponentInParent<PilierController>().isEmpty = false;
                    Inventory.inventory.RemoveAt(0);
                }
            }
        }
    }
}
