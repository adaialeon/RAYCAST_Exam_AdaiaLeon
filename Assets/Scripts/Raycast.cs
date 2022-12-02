using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{
    [SerializeField]private LayerMask rayLayer;
    private GameObject hitName;


    void Update()
    {
          
    //Si le damos al botón de disparar(botón izquierdo del ratón), que nos muestre los nombres de los objetos que clickamos 
    if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if(Physics.Raycast(ray, out rayHit, rayLayer))
            {

                Debug.Log(rayHit.point);
                transform.position = new Vector3(rayHit.point.x,transform.position.y ,rayHit.point.z);
                

                hitName = rayHit.transform.gameObject;
                Debug.Log(hitName);

                LoadLevel();

                
            }

            
        }        
    }

    void LoadLevel()
    {

        if(hitName.gameObject.layer == 6)
        {

            SceneManager.LoadScene(1);

        }
        if(hitName.gameObject.layer == 7)
        {

            SceneManager.LoadScene(2);

        }
        if(hitName.gameObject.layer == 8)
        {

            SceneManager.LoadScene(3);

        }

    }
}
