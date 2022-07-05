using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class rayInteract : MonoBehaviour
{
 
    
    
  public Transform rayoFound;
    [SerializeField]
    float rayDistance;
    [SerializeField]
    LayerMask layerMask;

    public Renderer renderer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        RaycastHit hitInfo;
        bool checkCollider = Physics.SphereCast(rayoFound.position,rayDistance,rayoFound.forward,out hitInfo);
        
       

        if(checkCollider)
        {
            if(hitInfo.collider.tag=="Cerebro"){
                renderer.material.color=Color.red;
            }
            
            Debug.Log("estas colisionando");
            
        }else{
            renderer.material.color=Color.white;
        }

    }



void OnDrawGizmos(){
    Gizmos.color = Color.blue;
    Gizmos.DrawWireSphere(rayoFound.position,rayDistance);
}


  
}
