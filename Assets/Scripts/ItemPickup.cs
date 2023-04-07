using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

//>>>>>>>>> This is where I put the on collider for tag player <<<<<<<<<
//    private void OnMouseDown() 
//    {
//        Pickup();
//    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Pickup();
        }
    }
}
