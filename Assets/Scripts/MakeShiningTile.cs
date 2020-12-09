using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MakeShiningTile : MonoBehaviour
{
    public AnimatedTile animatedTile;
    public Tilemap TilemapBackground;
    public Tilemap TilemapShining;
    public int width;
    public int height;

    void Start()
    {
        for(int w = 0; w < width; w++)
        {
            for(int h = 0; h < height; h++)
            {
                float wid = w + 0.5f;
                float hei = h + 0.5f;

                Vector3Int myPos = new Vector3Int(w, h, 0);
                if(TilemapBackground.GetTile(myPos) != null)
                {
                    int passerNumber = Random.Range(1, 21); //change this number to change spawn probability
                    int dividedNumber = passerNumber / 20;
                    if(dividedNumber == 1)
                    {
                        TilemapShining.SetTile(myPos, animatedTile);
                    }
                }
            }
        }
    }
}

