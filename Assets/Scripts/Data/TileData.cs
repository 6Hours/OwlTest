using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Data
{
    [System.Serializable]
    public class TileData
    {
        [SerializeField] private int tileId;
        [SerializeField] private string tileName;
        [SerializeField] private List<ResourceTypeEnum> resources;
        [SerializeField] private Color color;

        public string TileName
        {
            get
            {
                return tileName;
            }
        }
        public int TileId
        {
            get
            {
                return tileId;
            }
        }
        public Color Color
        {
            get
            {
                return color;
            }
        }
        public List<ResourceTypeEnum> Resources => resources;
    }
}
