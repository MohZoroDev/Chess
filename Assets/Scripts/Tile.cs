using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour, IPointerClickHandler
{
    void Start()
    {
        TilesManger.GetFromName(gameObject.name).tile = this;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        TileData data = TilesManger.GetFromName(gameObject.name);

        if (data.HavePieceA || data.HavePieceB)
        {
            TilesManger.Draw(gameObject.name);
        }
    }
}
