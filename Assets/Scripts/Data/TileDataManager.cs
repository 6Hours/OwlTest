using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Test.Data;
using UnityEngine;

namespace Test.InGame
{
    public class TileDataManager : MonoBehaviour
    {
        [SerializeField] private static List<ResourceType> ResourceTypes;
        [SerializeField] private static List<TileData> TileTypes;

        public List<ResourceType> resourceTypes;
        public List<TileData> tileTypes;
        private void Awake()
        {
            ResourceTypes = new List<ResourceType>();
            TileTypes = new List<TileData>();

            ResourceTypes.AddRange(resourceTypes);
            TileTypes.AddRange(tileTypes);
        }

        public static List<ResourceType> GetResourceList(ResourceTypeEnum[] ids)
        {
            return ResourceTypes.FindAll(res => ids.Any(id => id == res.ResourceId)).ToList();
        }

        public static TileData GenerateTileID(int[] seed, int i, int j)
        {
            return TileTypes[Mathf.Abs(seed.Sum(mltp => mltp * i + j * 
            seed[Mathf.Abs((i * j + mltp) % seed.Length)]
            )) % TileTypes.Count()];
        }
    }
}
