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

    int numTiles;

    // The spacing between objects, and the padding.
    [SerializeField]
    float spacing;
    // The size of cells
    [SerializeField]
    float cellSize;

    [SerializeField]
    InventoryTile tilePrefab;

    // The actual grid layout object
    [SerializeField]
    GridLayoutGroup grid;

    // Its transform
    [SerializeField]
    RectTransform gridShape;

    // The shape of the background
    [SerializeField]
    RectTransform backgroundShape;

    InventoryTile[,] gridTiles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numTiles = columns * rows;

        gridTiles = new InventoryTile[rows, columns];

        SetupGrid();

        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ScaleGrid()
    {
        Vector2 size = new Vector2(
            columns * cellSize + (columns - 1) * spacing,
            rows * cellSize + (rows - 1) * spacing
        );

        Vector2 backgroundSize = size;
        backgroundSize.x += 2 * spacing;
        backgroundSize.y += 2 * spacing;

        gridShape.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, size.x);
        gridShape.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, size.y);

        backgroundShape.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, backgroundSize.x);
        backgroundShape.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, backgroundSize.y);
    }

    void SetupGrid()
    {
        ScaleGrid();
        SetupGridValues();
    }

    void SetupGridValues()
    {
        grid.cellSize = new Vector2(cellSize, cellSize);
        grid.spacing = new Vector2(spacing, spacing);

        grid.constraintCount = rows;

    }
    void CreateGrid()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                InventoryTile newTile = CreateTileOnGrid();
                gridTiles[r, c] = newTile;
            }

        }
    }

    InventoryTile CreateTileOnGrid()
    {
        return Instantiate(tilePrefab, grid.transform, false);
    }
}
