using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public static class TilesManger
{
    public static TileData[,] board = new TileData[9, 9];

    public static void Init()
    {
        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                board[i, j] = new TileData();
            }
        }

    }
    public static TileData GetFromName(string name)
    {
        int i = name[1] - '0';
        int j = name[0] - 'a' + 1;

        return board[i, j];
    }

    public static string Add(string name, Vector2 vec)
    {
        int i = name[1] - '0';
        int j = name[0] - 'a' + 1;

        i += (int)vec.y;
        j += (int)vec.x;

        if (i > 8 || i < 1) return "-1";
        if (j > 8 || j < 1) return "-1";


        return Convert.ToChar(j + 'a' - 1) + i.ToString();
    }

    public static void Draw(string name)
    {
        List<string> objects = GetFromName(name).drawer.Draw();

        foreach (string str in objects)
        {
            GetFromName(str).tile.transform.Find("Reachable").gameObject.SetActive(true);
        }
    }
}
