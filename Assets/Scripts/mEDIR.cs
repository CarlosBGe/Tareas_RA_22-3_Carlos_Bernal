using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class mEDIR : MonoBehaviour
{
    public UnityEvent saludo;
    public UnityEvent ataque;
    
     public UnityEvent idle;
     public Transform target;

     public float distanciaMinima;

     public TextMeshProUGUI texto;

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(target.position,transform.position);


       

        Debug.Log("Distancia actual" + distancia);

         if(distancia < distanciaMinima){
            Debug.Log("hey tu");
            saludo.Invoke();
            ataque.Invoke();
            texto.text = "Hey tu" ;
         }else{
            idle.Invoke();
            texto.text = "Distancia actual " + distancia.ToString();
         }
        

    }

    void OnDrawGizmo(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,distanciaMinima);
    }
}
