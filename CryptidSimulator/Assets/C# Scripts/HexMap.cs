using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour
{
    [SerializeField] manager m;
    [SerializeField] HexRow[] hexRows;

    // Start is called before the first frame update
    void Start()
    {
        assignCoords();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void assignCoords()
    {
        for (int i = 0; i < hexRows.Length; i++)
        {
            hexRows[i].assignCoords(i);
        }
    }

    public void checkHexes()
    {
        for (int i = 0; i < hexRows.Length; i++)
        {
            hexRows[i].checkHex(m);
        }
    }

    public void clearHexes()
    {
        for (int i = 0; i < hexRows.Length; i++)
        {
            hexRows[i].clearHex();
        }
    }


}
