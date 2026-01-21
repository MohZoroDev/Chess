using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour, IDrawer
{
    private bool firstMove;
    public string TileName = "a2";
    public int MaximumSteps;

    void Start()
    {
        firstMove = true;
        TileName = transform.parent.name;
    }

    public List<string> Draw()
    {
        List<string> res = new List<string>();

        if (firstMove)
        {
            MaximumSteps = 2;
            firstMove = false;
        }
        else
        {
            MaximumSteps = 1;
        }

        for (int i = 1; i <= MaximumSteps; i++)
        {
            string str = TilesManger.Add(TileName, new Vector2(0, i));

            if (str == "-1") break;

            TileData data = TilesManger.GetFromName(str);

            if (data.HavePieceA || data.HavePieceB) break;

            res.Add(str);
        }

        return res;
    }
}
