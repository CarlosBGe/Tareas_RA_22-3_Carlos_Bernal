using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Rayo : MonoBehaviour
{
    public UnityEvent EventosCerebro;
    public UnityEvent CancelEvents;

    [SerializeField]
    GameObject cerebro;
    bool activarCerebro;

    [SerializeField]
     Image crosshair;

     public Color StartColor;
     public Color ImpactColor;

    Transform rayoFound;
    [SerializeField]
    float rayDistance;
    [SerializeField]
    LayerMask layerMask;


    // Start is called before the first frame update
    void Start()
    {
        rayoFound=Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        RayoCast();

        cerebro.SetActive(activarCerebro);

    }

    void RayoCast()
    {
        Ray ray= new Ray(rayoFound.position,rayoFound.forward);

        Debug.DrawRay(rayoFound.position,rayoFound.forward*rayDistance,Color.red);

        RaycastHit hitinfo;

        if (Physics.Raycast(ray,out hitinfo,rayDistance, layerMask))
        {
            if(hitinfo.collider != null)
            {
                switch(hitinfo.transform.tag)
                {
                    case "Cerebro":
                    activarCerebro = true;
                    EventosCerebro.Invoke();
                    break;
                }
                crosshair.color = ImpactColor;

                Debug.Log("Si encontro un collider");
            }
        }
        else
        {
            crosshair.color = StartColor;
            activarCerebro = false;
            CancelEvents.Invoke();
        }
    }
}
