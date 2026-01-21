using System;
using UnityEngine;
using UnityEngine.UI;


public class Manger : MonoBehaviour
{
    Image img;
    int startX = -425;
    int startY = 435;

    void Start()
    {
        img = transform.Find("Tile").GetComponent<Image>();
        Color32 a = new Color32(0xFF, 0xEF, 0xD3, 0xFF);
        Color32 b = new Color32(0x26, 0x24, 0x24, 0xFF);

        bool f = true;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                GameObject x = Instantiate(img.gameObject, transform);
                x.GetComponent<RectTransform>().localPosition = new Vector2(startX + j * 125, startY - i * 125);

                x.GetComponent<Image>().color = f ? a : b;

                x.name = "Tile " + Convert.ToChar((j + 'a')) + (8 - i).ToString();

                f = !f;

                x.SetActive(true);
            }

            f = !f;
        }
    }


    void Update()
    {

    }
}
