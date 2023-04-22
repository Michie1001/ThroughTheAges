using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInventoryCanvas : MonoBehaviour
{

    private GameObject InventoryCanvas;

    // Start is called before the first frame update
    private void Update()
    {
        InventoryCanvas = GameObject.FindGameObjectWithTag("Manager");
        InventoryCanvas.SetActive(false);
    }
}
