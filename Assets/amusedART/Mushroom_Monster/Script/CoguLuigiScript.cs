using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoguLuigiScript : MonoBehaviour{

    public Text texto;
    [Range(0.1f,10.0f)]public float distance = 3;
    private GameObject coguLuigi;
    
    void Start(){
        texto.enabled = false;
        coguLuigi = GameObject.FindWithTag ("Player");
    }

    void Update(){
        if(Vector3.Distance(transform.position,coguLuigi.transform.position) < distance){
            texto.enabled = true;
        } else{
            texto.enabled = false;
        }
    }
}
