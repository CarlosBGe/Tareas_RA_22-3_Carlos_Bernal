using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer render;

    public Color color01;
    public Color color02;
    // Start is called before the first frame update
    void Start()
    {
        render=GetComponent<Renderer>();
    }

    public void Color01Change()
    {
        render.material.color = color01;
    }

    public void Color02Change()
    {
        render.material.color = color02;
    }
}
