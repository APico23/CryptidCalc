using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public Region[] terrainOptions = new Region[5];


    bool isNotOne1;
    bool isNotOne2;

    //Within one
    public Region[] withinOne1 = new Region[5];
    public Territory[] withinOne2 = new Territory[2];

    public Region[] withinOne3 = new Region[5];
    public Territory[] withinOne4 = new Territory[2];

    //Not within one
    public Region[] notWithinOne1 = new Region[5];
    public Territory[] notWithinOne2 = new Territory[2];

    public Region[] notWithinOne3 = new Region[5];
    public Territory[] notWithinOne4 = new Territory[2];

    bool isNotTwo1;
    bool isNotTwo2;

    //Within two
    public Building[] withinTwo1 = new Building[8];
    public Territory[] withinTwo2 = new Territory[2];

    public Building[] withinTwo3 = new Building[8];
    public Territory[] withinTwo4 = new Territory[2];

    //Not within two
    public Building[] notWithinTwo1 = new Building[8];
    public Territory[] notWithinTwo2 = new Territory[2];

    public Building[] notWithinTwo3 = new Building[8];
    public Territory[] notWithinTwo4 = new Territory[2];

    bool isNotThree1;
    bool isNotThree2;

    //Within three
    public Building[] withinThree1 = new Building[8];
    
    public Building[] withinThree2 = new Building[8];

    //Not within three
    public Building[] notWithinThree1 = new Building[8];

    public Building[] notWithinThree2 = new Building[8];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
