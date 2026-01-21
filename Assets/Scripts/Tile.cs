using UnityEngine;
using UnityEngine.EventSystems;


public class TileData
{
    public bool HavePieceA;
    public bool HavePieceB;
    public bool AttackedByA;
    public bool AttackedByB;
}

public class Tile : MonoBehaviour, IPointerClickHandler
{
    public TileData data = new TileData();

    public void OnPointerClick(PointerEventData eventData)
    {
        if (data.HavePieceA || data.HavePieceB) Debug.Log(transform.GetChild(0).name);
    }
}
