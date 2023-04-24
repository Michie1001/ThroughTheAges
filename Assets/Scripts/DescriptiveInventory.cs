using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptiveInventory : MonoBehaviour
{
    [SerializeField]
    private DescriptiveInventoryItem itemPrefab;

    [SerializeField]
    private RectTransform contentPanel;

    List<DescriptiveInventoryItem> listOfItems = new List<DescriptiveInventoryItem>();

    public void InitializeInventoryUI(int inventorySize)
    {
        for(int i = 0; i < inventorySize; i++)
        {
            DescriptiveInventoryItem uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel);
            uiItem.transform.localScale = new Vector3(1, 1, 1);
            listOfItems.Add(uiItem);
        }
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
