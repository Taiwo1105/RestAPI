using TMPro;
using UnityEngine;

public class InventoryItemUI : MonoBehaviour
{
    public TextMeshProUGUI itemNameText;
    public TextMeshProUGUI quantityText;
    public TextMeshProUGUI weightText;

    public void SetItem(InventoryItem item)
    {
        itemNameText.text = item.itemName;
        quantityText.text = $"Quantity: {item.quantity}";
        weightText.text = $"Weight: {item.weight}";
    }
}
