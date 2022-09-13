using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMovement : MonoBehaviour
{
    public GameObject animCamera;
    
    //Objeto do tipo Animator
    public Animator anim;
    
    public GameObject arma;
    public GameObject disparo;


    void Start()
    {
        //Desabilita a camera de inicio
        animCamera.SetActive(false);
        
        //Referencia o objeto anim
        anim = GetComponent<Animator>();

        //Arma invisivel 
        arma.SetActive(false);
        disparo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Mira
        if(Input.GetMouseButton(1))
        {
            //Se clicar no mouse ativa camera
            animCamera.SetActive(true);
            //print("Mouse pressionado!");

            //Deixa objeto ativo
            anim.SetBool("anim", true);
            
            //Arma visivel 
            arma.SetActive(true);
        }

        //Atira direto
        else if(Input.GetMouseButton(0))
        {
            //Se clicar no mouse ativa camera
            animCamera.SetActive(true);
            //print("Mouse pressionado!");

            //Deixa objeto ativo
            anim.SetBool("anim", true);
            
            //Arma visivel 
            arma.SetActive(true);
            disparo.SetActive(true);
        }

        //Mira e atira
        else if(Input.GetMouseButton(0) & Input.GetMouseButton(0))
        {
            //Se clicar no mouse ativa camera
            animCamera.SetActive(true);
            //print("Mouse pressionado!");

            //Deixa objeto ativo
            anim.SetBool("anim", true);
            
            //Arma visivel 
            arma.SetActive(true);
            disparo.SetActive(true);
        }
        
        else
        {
            //O contrário fica desativada
            animCamera.SetActive(false);

            //Deixa objeto inativo
            anim.SetBool("anim", false);

            //Arma invisivel 
            arma.SetActive(false);
            disparo.SetActive(false);
        }
        
    }
}
