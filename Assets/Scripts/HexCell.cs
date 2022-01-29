using System;
using System.Collections;
using System.Collections.Generic;
using Test.Data;
using UnityEngine;

namespace Test.InGame
{
    public class HexCell : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer sprite;

        private TileData Data;

        public static Action<TileData, int, int> OnCellClick;

        public int X { get; private set; }
        public int Y { get; private set;}
        public void Initialize(TileData tile, int _x, int _y)
        {
            UpdateTile(tile);
            X = _x;
            Y = _y;
        }
        public void UpdateTile(TileData tileData)
        {
            Data = tileData;
            sprite.color = Data.Color;
        }
        public List<ResourceType> GetResourceList()
        {
            return TileDataManager.GetResourceList(Data.Resources.ToArray());
        }
        private void OnMouseUpAsButton()
        {
            Debug.Log(string.Format("click {0} {1}", X, Y));
            OnCellClick?.Invoke(Data, X, Y);
        }
    }
}
