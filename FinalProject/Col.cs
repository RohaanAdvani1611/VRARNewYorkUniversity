using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;
    public void Red()
    {
        for(int i=0; i<mats.Length; i++)
            mats[i].material.color = colors[0];
    }
    public void Blue()
    {
        for(int i=0; i<mats.Length; i++)
            mats[i].material.color = colors[1];
    }
    public void Yellow()
    {
        for(int i=0; i<mats.Length; i++)
            mats[i].material.color = colors[2];
    }
    public void Green()
    {
        for(int i=0; i<mats.Length; i++)
            mats[i].material.color = colors[3];
    }
    public void Pink()
    {
        for(int i=0; i<mats.Length; i++)
            mats[i].material.color = colors[4];
    }
    public void Orange()
    {
        for(int i=0; i<mats.Length; i++)
            mats[i].material.color = colors[5];
    }
    public void ChangeMat()
    {   
        for(int i=0; i<mats.Length; i++)
            mats[i].material = mats[(i+1)%mats.Length].material;
    }
}
