using System;
using UnityEngine;
using UnityEngine.UI;


public class Manger : MonoBehaviour
{
    public GameObject Tile;
    public GameObject Pawn;
    public GameObject Rock;
    public GameObject Bishop;
    public GameObject Knight;
    public GameObject Queen;
    public GameObject King;

    int startX = -425;
    int startY = 435;



    void SpawnPiece(GameObject piece, string pos, string name, bool isPlayerA)
    {
        GameObject x = Instantiate(piece, transform.Find("Tile " + pos));
        x.name = name;

        x.transform.parent.GetComponent<Tile>().data.HavePieceA = isPlayerA;
        x.transform.parent.GetComponent<Tile>().data.HavePieceB = !isPlayerA;
    }
    
    void SpawnFullPieces(bool isPlayerA)
    {
        char pawnRow = isPlayerA ? '2' : '7';
        char piecesRow = isPlayerA ? '1' : '8';

        for (int i = 0; i < 8; i++)
        {
            SpawnPiece(Pawn, Convert.ToChar(i + 'a') + "" + pawnRow, "Pawn", isPlayerA);
        }

        SpawnPiece(Rock, "a" + piecesRow, "Left Rock", isPlayerA);
        SpawnPiece(Rock, "h" + piecesRow, "Right Rock", isPlayerA);

        SpawnPiece(Knight, "b" + piecesRow, "Left Knight", isPlayerA);
        SpawnPiece(Knight, "g" + piecesRow, "Right Knight", isPlayerA);

        SpawnPiece(Bishop, "c" + piecesRow, "Left Bishop", isPlayerA);
        SpawnPiece(Bishop, "f" + piecesRow, "Right Bishop", isPlayerA);

        SpawnPiece(Queen, "d" + piecesRow, "Queen", isPlayerA);
        SpawnPiece(King, "e" + piecesRow, "King", isPlayerA);
    }

    void Start()
    {
        Color32 a = new Color32(0xFF, 0xEF, 0xD3, 0xFF);
        Color32 b = new Color32(0x26, 0x24, 0x24, 0xFF);

        bool f = true;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                GameObject x = Instantiate(Tile.gameObject, transform);
                x.GetComponent<RectTransform>().localPosition = new Vector2(startX + j * 125, startY - i * 125);

                x.GetComponent<Image>().color = f ? a : b;

                x.name = "Tile " + Convert.ToChar((j + 'a')) + (8 - i).ToString();

                f = !f;
            }

            f = !f;
        }

        SpawnFullPieces(false);
        SpawnFullPieces(true);
    }

    void Update()
    {

    }
}
