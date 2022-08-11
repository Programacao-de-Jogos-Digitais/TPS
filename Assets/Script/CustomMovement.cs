using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMovement : MonoBehaviour
{
    public GameObject animCamera;
    // Start is called before the first frame update
    void Start()
    {
        //Desabilita a camera de inicio
        animCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            //Se clicar no mouse ativa camera
            animCamera.SetActive(true);
            print("Mouse pressionado!");
        }
        else
        {
            //O contrário fica desativada
            animCamera.SetActive(false);
        }
        
    }
}
