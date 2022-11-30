using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Arma : MonoBehaviour
{
    // Start is called before the first frame update
    ComtroleJogador controle;
    public AudioSource audioS;
    public AudioClip soundTiro;
    public AudioClip soundSpray;
    private bool isSelecionado;

     Carregamento car;

  private void Awake() {

    isSelecionado = false;
    controle = new ComtroleJogador();
    //audioS = GetComponent<AudioSource>();
    car = (Carregamento)gameObject.GetComponent(typeof(Carregamento));
    controle.Gameplay.AcionaArma.performed += ctx => Acionar();
  }

    public void Update()
    {
        if(car.encheu == true)
        {
            Debug.Log("Entrouuuuuuuuuuuuuuuuuuuuu");
            SelecionaArma();
            car.encheu = false;
        }
        
    }

    private void Acionar()
    {
        Debug.Log("SELECIONADO no acionar" + isSelecionado);
        audioS.PlayOneShot(soundSpray);
        if (isSelecionado)
        {
          audioS.PlayOneShot(soundTiro);
        }

    }

   public void SelecionaArma()
    {
        isSelecionado = true;
    }
    // public void DesselecionaArma()
    //{
    // Debug.Log("Saiu da arma");
    // isSelecionado = false;
    // }
    public void OnPointerEnter()
    {
        
    }
    public void OnPointerExit()
    {
        isSelecionado = false;
        car.encheu = false;
        Debug.Log("Saiu da arma 2");
    }



    private void OnEnable() {
     controle.Gameplay.Enable();
    }
    private void OnDisable() {
    controle.Gameplay.Disable();
    }
}
