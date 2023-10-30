using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel;

[ExecuteInEditMode]
public class Hex : MonoBehaviour
{
    public Region region;
    public Territory territory;
    public Building building;
    public bool isPossible;
    public bool isChecking;
    public Vector2 coords;

    [SerializeField] Image r;
    [SerializeField] Image t1;
    [SerializeField] Image t2;
    [SerializeField] Image b1;
    [SerializeField] Image b2;
    [SerializeField] Image h;


    Region getRegion() { return region; }

    Territory getTerritory() { return territory; }

    Building getBuilding() { return building; }

    private void Update()
    {
        setR();
        setT();
        setB();
        setH();
    }

    void setR()
    {
        switch (region)
        {
            case Region.water:
                r.color = new Color(0.082f, 0.007f, 0.420f, 1f); break;
            case Region.mountain:
                r.color = Color.grey; break;
            case Region.forest:
                r.color = new Color(0.007f,0.420f,0.082f,1); break;
            case Region.swamp:
                r.color = new Color(0.345f,0.007f,0.420f, 1); break;
            case Region.desert:
                r.color = Color.yellow; break;
        }
    }

    void setT()
    {
        switch(territory) {
            case Territory.bear:
                t1.enabled = true; t2.enabled = false; break;
            case Territory.cougar:
                t2.enabled = true; t1.enabled = false; break;
            case Territory.none: 
                t1.enabled = false; t2.enabled = false; break;
        }
    }

    void setB()
    {
        switch(building)
        {
            case Building.buAS:
                b1.enabled = true; b2.enabled = false; b1.color= Color.blue; break;
            case Building.blAS:
                b1.enabled = true; b2.enabled = false; b1.color = Color.black; break;
            case Building.grAS:
                b1.enabled = true; b2.enabled = false; b1.color = Color.green; break;
            case Building.whAS:
                b1.enabled = true; b2.enabled = false; b1.color = Color.white; break;
            case Building.buSS:
                b2.enabled = true; b1.enabled = false; b2.color = Color.blue; break;
            case Building.blSS:
                b2.enabled = true; b1.enabled = false; b2.color = Color.black; break;
            case Building.grSS:
                b2.enabled = true; b1.enabled = false; b2.color = Color.green; break;
            case Building.whSS:
                b2.enabled = true; b1.enabled = false; b2.color = Color.white; break;
            case Building.none:
                b1.enabled = false; b2.enabled = false;  break;
        }
    }

    void setH()
    {
        if (isChecking)
        {
            if (isPossible) { h.enabled = true; h.color = new Color(); }
            else { h.enabled = true; h.color = new Color(); }
        }
        else
        {
            h.enabled = false;
        }

    }

}