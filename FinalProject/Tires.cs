using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tires : MonoBehaviour
{
    public Color[] tirecolor;
    public Renderer[] tires;
    public void Black()
    {
        for(int i=0; i<tires.Length; i++)
            tires[i].material.color = tirecolor[0];
    }
    public void White()
    {
        for(int i=0; i<tires.Length; i++)
            tires[i].material.color = tirecolor[1];
    }
    public void Gray()
    {
        for(int i=0; i<tires.Length; i++)
            tires[i].material.color = tirecolor[2];
    }
}
