using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptiveInventoryController : MonoBehaviour
{
    [SerializeField]
    private DescriptiveInventory inventoryUI;

    public int inventorySize = 15;

    private void Start()
    {
        inventoryUI.InitializeInventoryUI(inventorySize);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(inventoryUI.isActiveAndEnabled == false)
            {
                inventoryUI.Show();
            }
            else
            {
                inventoryUI.Hide();
            }
        }
    }
}
