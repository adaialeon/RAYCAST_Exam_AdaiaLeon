using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{

   [SerializeField]private LayerMask ignoreLayer;


    void update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 10f, ignoreLayer))
        {
            //DEVOLVER POSICION
            Vector3 hitPosition = hit.point;
		    //DEVOLVER NOMBRE
            string hitName = hit.transform.name;
		    //DEVOLVER TAG
            string hitTag = hit.transform.tag;
		    //DEVOLVER DISTANCIA
            float hitDistance = hit.distance;
		    //ANIMATOR
            Animator hitAnim = hit.transform.gameObject.GetComponent<Animator>();
		    //DIBUJAR EL RAYO DE COLOR
            Debug.DrawRay(transform.position, transform.forward * hitDistance, Color.green);
        }

        //Detecta la esfera
        if(hitTag == "Esfera")
        {

            Debug.Log("impacto en obstaculo");

        }
        else 
        {
            Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if(Physics.Raycast(ray, out rayHit))
            {
                Debug.Log(rayHit.transform.name);
            }
        }

        //Detecta el cubo grande
        if(hitTag == "CuboGrande")
        {

            Debug.Log("impacto en obstaculo");

        }
        else 
        {
            Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if(Physics.Raycast(ray, out rayHit))
            {
                Debug.Log(rayHit.transform.name);
            }
        }

        //Detecta el cubo pequeño
        if(hitTag == "CuboPequeño")
        {

            Debug.Log("impacto en obstaculo");

        }
        else 
        {
            Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if(Physics.Raycast(ray, out rayHit))
            {
                Debug.Log(rayHit.transform.name);
            }
        }

        /*if(("Fire1" == "CuboGrande"))
        {
            SceneManager.LoadScene("Scene1 1");

        } 

        if((Fire1 == "Esfera"))
        {
            SceneManager.LoadScene("Scene1 2");

        }  

        if((Fire1 == "CuboPequeño"))
        {
            SceneManager.LoadScene("Scene1 3");

        }*/
    
    }

    void start()
    {

    }
   

}