using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public HexMap hexMap;

    public Region[] regionOptions = new Region[5];

   public bool isNotOne1;
   public bool isNotOne2;

    //Within one
    public Region[] withinOne1 = new Region[5];
    public Territory[] withinOne2 = new Territory[2];

    public Region[] withinOne3 = new Region[5];
    public Territory[] withinOne4 = new Territory[2];

    //Not within one
 //   public Region[] notWithinOne1 = new Region[5];
 //   public Territory[] notWithinOne2 = new Territory[2];

 //   public Region[] notWithinOne3 = new Region[5];
 //   public Territory[] notWithinOne4 = new Territory[2];

   public bool isNotTwo1;
   public bool isNotTwo2;

    //Within two
    public Building[] withinTwo1 = new Building[8];
    public Territory[] withinTwo2 = new Territory[2];

    public Building[] withinTwo3 = new Building[8];
    public Territory[] withinTwo4 = new Territory[2];

    //Not within two
 //   public Building[] notWithinTwo1 = new Building[8];
  //  public Territory[] notWithinTwo2 = new Territory[2];

  //  public Building[] notWithinTwo3 = new Building[8];
  //  public Territory[] notWithinTwo4 = new Territory[2];

    public bool isNotThree1;
    public bool isNotThree2;

    //Within three
    public Building[] withinThree1 = new Building[8];
    
    public Building[] withinThree2 = new Building[8];

    //Not within three
  //  public Building[] notWithinThree1 = new Building[8];

   // public Building[] notWithinThree2 = new Building[8];

    // Update is called once per frame
    
    void setLists()
    {
        isNotOne1 = false; isNotOne2 = false;
        isNotTwo1 = false; isNotTwo2 = false;
        isNotThree1 = false; isNotThree2 = false;

        for (int i = 0; i < regionOptions.Length; i++)
        {
            regionOptions[i] = Region.none;
            withinOne1[i] = Region.none;
            withinOne3[i] = Region.none;
        }
        for (int i = 0; i < withinOne2.Length; i++)
        {
            withinOne2[i] = Territory.none;
            withinOne4[i] = Territory.none;
            withinTwo2[i] = Territory.none;
            withinTwo4[i] = Territory.none;
        }
        for (int i = 0; i < withinTwo1.Length; i++)
        {
            withinTwo1[i] = Building.none;
            withinTwo3[i] = Building.none;
            withinThree1[i] = Building.none;
            withinThree2[i] = Building.none;
        }

    }

    void Start()
    {
        setLists();
    }

    void Update()
    {

    }

    internal void waterSelect1()
    {
        if (regionOptions[0] == Region.none)
        {
            regionOptions[0] = Region.water;
        } else
        {
            regionOptions[0] = Region.none;
        }
        
    }
    internal void mountainSelect1()
    {
        if (regionOptions[1] == Region.none)
        {
            regionOptions[1] = Region.mountain;
        }
        else
        {
            regionOptions[1] = Region.none;
        }

    }

    internal void forestSelect1()
    {
        if (regionOptions[2] == Region.none)
        {
            regionOptions[2] = Region.forest;
        }
        else
        {
            regionOptions[2] = Region.none;
        }

    }

    internal void swampSelect1()
    {
        if (regionOptions[3] == Region.none)
        {
            regionOptions[3] = Region.swamp;
        }
        else
        {
            regionOptions[3] = Region.none;
        }

    }

    internal void desertSelect1()
    {
        if (regionOptions[4] == Region.none)
        {
            regionOptions[4] = Region.desert;
        }
        else
        {
            regionOptions[4] = Region.none;
        }

    }

    internal void isNot1()
    {
        isNotOne1 = !isNotOne1;
    }

    internal void isNot2()
    {
        isNotOne2 = !isNotOne2;
    }

    internal void isNot3()
    {
        isNotTwo1= !isNotTwo1;
    }

    internal void isNot4()
    {
        isNotTwo2= !isNotTwo2;
    }

    internal void isNot5()
    {
        isNotThree2= !isNotThree2;
    }

    internal void isNot6()
    {
        isNotThree1= !isNotThree1;
    }

    internal void waterSelect2()
    {
        if (withinOne1[0] == Region.none)
        {
            withinOne1[0] = Region.water;
        }
        else
        {
            withinOne1[0] = Region.none;
        }

    }

    internal void mountainSelect2()
    {
        if (withinOne1[1] == Region.none)
        {
            withinOne1[1] = Region.mountain;
        }
        else
        {
            withinOne1[1] = Region.none;
        }

    }

    internal void forestSelect2()
    {
        if (withinOne1[2] == Region.none)
        {
            withinOne1[2] = Region.forest;
        }
        else
        {
            withinOne1[2] = Region.none;
        }

    }

    internal void swampSelect2()
    {
        if (withinOne1[3] == Region.none)
        {
            withinOne1[3] = Region.swamp;
        }
        else
        {
            withinOne1[3] = Region.none;
        }

    }

    internal void desertSelect2()
    {
        if (withinOne1[4] == Region.none)
        {
            withinOne1[4] = Region.desert;
        }
        else
        {
            withinOne1[4] = Region.none;
        }

    }

    internal void waterSelect3()
    {
        if (withinOne3[0] == Region.none)
        {
            withinOne3[0] = Region.water;
        }
        else
        {
            withinOne3[0] = Region.none;
        }

    }

    internal void mountainSelect3()
    {
        if (withinOne3[1] == Region.none)
        {
            withinOne3[1] = Region.mountain;
        }
        else
        {
            withinOne3[1] = Region.none;
        }

    }

    internal void forestSelect3()
    {
        if (withinOne3[2] == Region.none)
        {
            withinOne3[2] = Region.forest;
        }
        else
        {
            withinOne3[2] = Region.none;
        }

    }

    internal void swampSelect3()
    {
        if (withinOne3[3] == Region.none)
        {
            withinOne3[3] = Region.swamp;
        }
        else
        {
            withinOne3[3] = Region.none;
        }

    }

    internal void desertSelect3()
    {
        if (withinOne3[4] == Region.none)
        {
            withinOne3[4] = Region.desert;
        }
        else
        {
            withinOne3[4] = Region.none;
        }

    }

    internal void animalSelect1()
    {
        if (withinOne2[0] == Territory.none)
        {
            withinOne2[0] = Territory.cougar;
            withinOne2[1] = Territory.bear;
        }
        else
        {
            withinOne2[0] = Territory.none;
            withinOne2[1] = Territory.none;
        }
    }

    internal void animalSelect2()
    {
        if (withinOne4[0] == Territory.none)
        {
            withinOne4[0] = Territory.cougar;
            withinOne4[1] = Territory.bear;
        }
        else
        {
            withinOne4[0] = Territory.none;
            withinOne4[1] = Territory.none;
        }
    }

    internal void cougarSelect1()
    {
        if (withinTwo2[0] == Territory.none)
        {
            withinTwo2[0] = Territory.cougar;
        }
        else
        {
            withinTwo2[0] = Territory.none;
        }
    }

    internal void bearSelect1()
    {
        if (withinTwo2[1] == Territory.none)
        {
            withinTwo2[1] = Territory.bear;
        }
        else
        {
            withinTwo2[1] = Territory.none;
        }
    }

    internal void cougarSelect2()
    {
        if (withinTwo4[0] == Territory.none)
        {
            withinTwo4[0] = Territory.cougar;
        }
        else
        {
            withinTwo4[0] = Territory.none;
        }
    }

    internal void bearSelect2()
    {
        if (withinTwo4[1] == Territory.none)
        {
            withinTwo4[1] = Territory.bear;
        }
        else
        {
            withinTwo4[1] = Territory.none;
        }
    }

    internal void ssSelect1()
    {
        if (withinTwo1[0] == Building.none)
        {
            withinTwo1[0] = Building.blSS;
            withinTwo1[1] = Building.buSS;
            withinTwo1[2] = Building.whSS;
            withinTwo1[3] = Building.grSS;
        }
        else
        {
            withinTwo1[0] = Building.none;
            withinTwo1[1] = Building.none;
            withinTwo1[2] = Building.none;
            withinTwo1[3] = Building.none;
        }
    }

    internal void asSelect1()
    {
        if (withinTwo1[4] == Building.none)
        {
            withinTwo1[4] = Building.blAS;
            withinTwo1[5] = Building.buAS;
            withinTwo1[6] = Building.whAS;
            withinTwo1[7] = Building.grAS;
        }
        else
        {
            withinTwo1[4] = Building.none;
            withinTwo1[5] = Building.none;
            withinTwo1[6] = Building.none;
            withinTwo1[7] = Building.none;
        }
    }

    internal void ssSelect2()
    {
        if (withinTwo3[0] == Building.none)
        {
            withinTwo3[0] = Building.blSS;
            withinTwo3[1] = Building.buSS;
            withinTwo3[2] = Building.whSS;
            withinTwo3[3] = Building.grSS;
        }
        else
        {
            withinTwo3[0] = Building.none;
            withinTwo3[1] = Building.none;
            withinTwo3[2] = Building.none;
            withinTwo3[3] = Building.none;
        }
    }

    internal void asSelect2()
    {
        if (withinTwo3[4] == Building.none)
        {
            withinTwo3[4] = Building.blAS;
            withinTwo3[5] = Building.buAS;
            withinTwo3[6] = Building.whAS;
            withinTwo3[7] = Building.grAS;
        }
        else
        {
            withinTwo3[4] = Building.none;
            withinTwo3[5] = Building.none;
            withinTwo3[6] = Building.none;
            withinTwo3[7] = Building.none;
        }
    }

    internal void blackSelect1()
    {
        if (withinThree1[0] == Building.none)
        {
            withinThree1[0] = Building.blSS;
            withinThree1[4] = Building.blAS;
        }
        else
        {
            withinThree1[0] = Building.none;
            withinThree1[4] = Building.none;
        }
    }

    internal void blueSelect1()
    {
        if (withinThree1[1] == Building.none)
        {
            withinThree1[1] = Building.buSS;
            withinThree1[5] = Building.buAS;
        }
        else
        {
            withinThree1[1] = Building.none;
            withinThree1[5] = Building.none;
        }
    }

    internal void whiteSelect1()
    {
        if (withinThree1[2] == Building.none)
        {
            withinThree1[2] = Building.whSS;
            withinThree1[6] = Building.whAS;
        }
        else
        {
            withinThree1[2] = Building.none;
            withinThree1[6] = Building.none;
        }
    }

    internal void greenSelect1()
    {
        if (withinThree1[3] == Building.none)
        {
            withinThree1[3] = Building.grSS;
            withinThree1[7] = Building.grAS;
        }
        else
        {
            withinThree1[3] = Building.none;
            withinThree1[7] = Building.none;
        }
    }


    internal void blackSelect2()
    {
        if (withinThree2[0] == Building.none)
        {
            withinThree2[0] = Building.blSS;
            withinThree2[4] = Building.blAS;
        }
        else
        {
            withinThree2[0] = Building.none;
            withinThree2[4] = Building.none;
        }
    }

    internal void blueSelect2()
    {
        if (withinThree2[1] == Building.none)
        {
            withinThree2[1] = Building.buSS;
            withinThree2[5] = Building.buAS;
        }
        else
        {
            withinThree2[1] = Building.none;
            withinThree2[5] = Building.none;
        }
    }

    internal void whiteSelect2()
    {
        if (withinThree2[2] == Building.none)
        {
            withinThree2[2] = Building.whSS;
            withinThree2[6] = Building.whAS;
        }
        else
        {
            withinThree2[2] = Building.none;
            withinThree2[6] = Building.none;
        }
    }

    internal void greenSelect2()
    {
        if (withinThree2[3] == Building.none)
        {
            withinThree2[3] = Building.grSS;
            withinThree2[7] = Building.grAS;
        }
        else
        {
            withinThree2[3] = Building.none;
            withinThree2[7] = Building.none;
        }
    }

    /*
    public void checkMap()
    {
        hexMap.checkHexes();
    }

    public void clearMap()
    {
        hexMap.clearHexes();
    }

    */
}
