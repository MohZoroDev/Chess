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

        for (int i = 0; i < 8; i++)
        {
            GameObject p1 = Instantiate(Pawn, transform.Find("Tile " + Convert.ToChar(i + 'a') + '7'));

            p1.GetComponent<RectTransform>().localPosition = Vector2.zero;

            GameObject p2 = Instantiate(Pawn, transform.Find("Tile " + Convert.ToChar(i + 'a') + '2'));
            p2.GetComponent<RectTransform>().localPosition = Vector2.zero;
        }

        GameObject r1 = Instantiate(Rock, transform.Find("Tile a8"));
        GameObject r2 = Instantiate(Rock, transform.Find("Tile h8"));

        GameObject r3 = Instantiate(Rock, transform.Find("Tile a1"));
        GameObject r4 = Instantiate(Rock, transform.Find("Tile h1"));

        GameObject k1 = Instantiate(Knight, transform.Find("Tile b8"));
        GameObject k2 = Instantiate(Knight, transform.Find("Tile g8"));

        GameObject k3 = Instantiate(Knight, transform.Find("Tile b1"));
        GameObject k4 = Instantiate(Knight, transform.Find("Tile g1"));

        GameObject b1 = Instantiate(Bishop, transform.Find("Tile c8"));
        GameObject b2 = Instantiate(Bishop, transform.Find("Tile f8"));

        GameObject b3 = Instantiate(Bishop, transform.Find("Tile c1"));
        GameObject b4 = Instantiate(Bishop, transform.Find("Tile f1"));

        GameObject q1 = Instantiate(Queen, transform.Find("Tile d8"));

        GameObject q2 = Instantiate(Queen, transform.Find("Tile d1"));

        GameObject ki1 = Instantiate(King, transform.Find("Tile e8"));
        
        GameObject ki2 = Instantiate(King, transform.Find("Tile e1"));
    }




    void Update()
    {

    }
}
