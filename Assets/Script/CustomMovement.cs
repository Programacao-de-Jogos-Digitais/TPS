using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMovement : MonoBehaviour
{
    public GameObject animCamera;
    
    //Objeto do tipo Animator
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //Desabilita a camera de inicio
        animCamera.SetActive(false);
        
        //Referencia o objeto anim
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            //Se clicar no mouse ativa camera
            animCamera.SetActive(true);
            print("Mouse pressionado!");

            //Deixa objeto ativo
            anim.SetBool("anim", true);
        }
        else
        {
            //O contrário fica desativada
            animCamera.SetActive(false);

            //Deixa objeto inativo
            anim.SetBool("anim", false);
        }
        
    }
}
