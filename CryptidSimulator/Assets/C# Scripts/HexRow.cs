using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexRow : MonoBehaviour
{
    [SerializeField] Hex[] hexes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void assignCoords(int n)
    {
        int x = n;
        int y = n % 2;
        for (int i = 0; i < hexes.Length; i++)
        {
            hexes[i].coords = new Vector2(x, y);
            y += 2;
        }
    }

    public void checkHex()
    {
        for (int i = 0; i < hexes.Length; i++)
        {
            hexes[i].isChecking= true;
            if (hexChecker(hexes[i]))
            {
                hexes[i].isPossible = true;
            }
            else
            {
                hexes[i].isPossible = false;
            }
        }
    } 

    bool hexChecker(Hex h)
    {
        return true;
    }
}
