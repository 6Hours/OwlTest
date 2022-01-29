using System.Linq;
using Test.Data;
using Test.InGame;
using UnityEngine;
using UnityEngine.UI;

namespace Test.UI
{
    public class TileInfoScreen : MonoBehaviour
    {
        [SerializeField] private GameObject activeObject;
        [SerializeField] private Text tileNameText;
        [SerializeField] private Text tileResourcesText;
        [SerializeField] private Button closeButton;

        private void Start()
        {
            closeButton.onClick.AddListener(CloseScreen);
            HexCell.OnCellClick += (tile, x, y) => ShowTileInfo(tile);
        }

        private void ShowTileInfo(TileData tile)
        {
            activeObject.SetActive(true);
            tileNameText.text = tile.TileName;
            tileResourcesText.text = string.Join("\n", TileDataManager.GetResourceList(tile.Resources.ToArray())
                .Select(res => res.ResourceName));
        }
        private void CloseScreen()
        {
            activeObject.SetActive(false);
        }
    }
}
