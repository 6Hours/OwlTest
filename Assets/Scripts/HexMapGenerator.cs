using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Test.InGame;
using UnityEngine;

namespace Test.InGame
{
    public class HexMapGenerator : MonoBehaviour
    {
        [SerializeField] public GameObject prefab;

        public string seed;
        public float TileWidth;
        public float TileHeight;

        private int currentX = 0, currentY = 0;
        private HexCell[,] fieldCells;
        private int[] parseSeed;

        private void Start()
        {
            parseSeed = seed.Select(ch => int.Parse(ch.ToString())).ToArray();

            GenerateField(24, 24);
            HexCell.OnCellClick += (data, x, y) => UpdateField(x, y);
        }
        private void GenerateField(int width, int height) //field size
        {
            fieldCells = new HexCell[width, height];

            for (var i = 0; i < width; i++)
                for (var j = 0; j < height; j++)
                {
                    GameObject temp = Instantiate(prefab,
                        new Vector2(
                            (j % 2 != 0 ? TileWidth / 2f : 0f) + TileWidth * (i - width/2),
                            TileHeight * (j - height / 2)),
                        Quaternion.identity);

                    fieldCells[i, j] = temp.GetComponent<HexCell>();

                    fieldCells[i, j].Initialize(
                        TileDataManager.GenerateTileID(parseSeed, (i - width / 2), (j - height / 2)), (i - width / 2), (j - height / 2));
                }
        }
        private void UpdateField(int x, int y)
        {
            currentX += x;
            currentY += y;
            Debug.Log(string.Format("current x{0} y{1}", currentX, currentY));
            for (var i = 0; i < fieldCells.GetLength(0); i++)
                for (var j = 0; j < fieldCells.GetLength(1); j++)
                {
                    fieldCells[i, j].UpdateTile(TileDataManager.GenerateTileID(parseSeed,
                        fieldCells[i, j].X + currentX, fieldCells[i, j].Y + currentY));
                }
        }
    }
}
