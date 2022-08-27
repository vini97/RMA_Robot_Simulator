using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoguMarioScript : MonoBehaviour{

    public Text texto;
    [Range(0.1f,10.0f)]public float distance = 3;
    private GameObject coguMario;
    
    void Start(){
        texto.enabled = false;
        coguMario = GameObject.FindWithTag ("Player");
    }

    void Update(){
        if(Vector3.Distance(transform.position,coguMario.transform.position) < distance){
            texto.enabled = true;
        } else{
            texto.enabled = false;
        }
    }
}
