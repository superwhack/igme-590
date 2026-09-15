using System;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGrid : MonoBehaviour
{
    // The number of rows and columns
    [SerializeField]
    int rows;
    [SerializeField]
    int columns;
    
    // The spacing between objects, and the padding.
    [SerializeField]
    float spacing;

    // The size of cells
    [SerializeField]
    float cellSize;

    // The actual grid layout object
    [SerializeField]
    GridLayoutGroup grid;

    // Its transform
    [SerializeField]
    RectTransform gridShape;

    // The shape of the background
    [SerializeField]
    RectTransform backgroundShape;

    Vector2 calculatedSize;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
