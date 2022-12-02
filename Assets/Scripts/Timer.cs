using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text Tempo;
    public float Tiempo = 0.0f;
    public bool DebeAumentar = false;
    public bool CuentaRegresiva = true;
    public GameObject esfera;
    public GameObject cuboGrande;
    public GameObject cuboPequeño;


    void Update() 
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Debug.Log("He clickado");
            Instantiate(esfera, transform.position, transform.rotation);
            Instantiate(cuboGrande, transform.position, transform.rotation);
            Instantiate(cuboPequeño, transform.position, transform.rotation);
        
        }

        if(CuentaRegresiva == true)
        {
            if(DebeAumentar) 
            Tiempo += Time.deltaTime; 
    
            else 
            {
                if (Tiempo <= 0.0f)  
                { 
                    DebeAumentar = false; 
                } 
                else 
                { 
                    Tiempo -= Time.deltaTime; 
                } 
            }

            Tempo.text = "Tiempo:" + " " + Tiempo.ToString ("f0");
        }

    }

 }

