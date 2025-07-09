using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class PlayerUIController : MonoBehaviour
{
    [Header("Player Info")]
    public TextMeshProUGUI playerInfoText;

    [Header("Inventory UI")]
    public Transform inventoryListParent;
    public GameObject inventoryItemPrefab;

    public void DisplayPlayerData(PlayerRecord record)
    {
        playerInfoText.text = $"<b>{record.playerName}</b>\n" +
                              $"Level: {record.level}\n" +
                              $"Health: {record.health}\n" +
                              $"Position: ({record.position.x}, {record.position.y}, {record.position.z})";

        // Clear previous inventory
        foreach (Transform child in inventoryListParent)
        {
            Destroy(child.gameObject);
        }

        foreach (var item in record.inventory)
        {
            GameObject itemGO = Instantiate(inventoryItemPrefab, inventoryListParent);
            InventoryItemUI itemUI = itemGO.GetComponent<InventoryItemUI>();
            itemUI.SetItem(item);
        }
    }

    internal void DisplayPlayerData(PlayerRecord record, object itemUI)
    {
        throw new NotImplementedException();
    }
}
