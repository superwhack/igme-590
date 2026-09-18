using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    int itemId;

    int uniqueId;

    bool held;

    [SerializeField]
    InventoryItemShape shape;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Lerp towards mouse position if held?
    }


    void AttemptPickup()
    {
        // Check if there's already something held (which isn't expected, but still)
        
        // Check something else?
    }


    void Pickup()
    {
        // Tell all the grid tiles they aren't occupied

        // Tell the inventory manager that this is the held item
    }

    void AttemptRelease()
    {
        // See if the mouse is over an InventoryGrid (check from InventoryManager, then Inventory)

        // If so, see the closest tile to the center of the shape

        // Is the center available?

        // If so, then check each other tile from the shape

        // If the 

    }

    void Release(Vector2Int centerLocation)
    {
        
    }
}
