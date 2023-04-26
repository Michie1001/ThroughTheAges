using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptiveInventory : MonoBehaviour
{
    [SerializeField]
    private DescriptiveInventoryItem itemPrefab;

    [SerializeField]
    private RectTransform contentPanel;

    [SerializeField]
    private DescriptiveInventoryItemDescription itemDescription;

    List<DescriptiveInventoryItem> listOfItems = new List<DescriptiveInventoryItem>();

    private void Awake()
    {
        Hide();
    }

    public void InitializeInventoryUI(int inventorySize)
    {
        for(int i = 0; i < inventorySize; i++)
        {
            DescriptiveInventoryItem uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel);
            uiItem.transform.localScale = new Vector3(1, 1, 1);
            listOfItems.Add(uiItem);
            uiItem.OnItemClicked += HandleItemSelection;
        }
    }

    private void HandleItemSelection(DescriptiveInventoryItem obj)
    {
        throw new KeyNotFoundException();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        itemDescription.ResetDescription();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
