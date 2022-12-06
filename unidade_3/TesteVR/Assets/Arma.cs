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
    public static bool isSelecionado;

     Carregamento car;

  private void Awake() {

    isSelecionado = false;
    controle = new ComtroleJogador();
    //audioS = GetComponent<AudioSource>();
    car = (Carregamento)gameObject.GetComponent(typeof(Carregamento));
    controle.Gameplay.AcionaArma.performed += ctx => Acionar();
    controle.Gameplay.Testar.performed += ctx => TestaSom();
    }

    public void Update()
    {
        if(car.encheu == true)
        {
            Debug.Log("Entrouuuuuuuuuuuuuuuuuuuuu: "+ car.encheu +" "+ isSelecionado);
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
            Debug.Log("Acionaaar: " + car.encheu + " " + isSelecionado);
            audioS.PlayOneShot(soundTiro);
        }

    }

    private void TestaSom()
    {
        audioS.PlayOneShot(soundSpray);
    }

   public void SelecionaArma()
    {
        Debug.Log("public void SelecionaArma()");
        isSelecionado = true;
    }
    // public void DesselecionaArma()
    //{
    // Debug.Log("Saiu da arma");
    // isSelecionado = false;
    // }
    public void OnPointerEnter()
    {
        Debug.Log("onpointerenterArma");
    }
    public void OnPointerExit()
    {
        isSelecionado = false;
        car.encheu = false;
        Debug.Log("Saiu da arma 2");
    }

    public void testar()
    {
        Debug.Log("TESTEEEEEEEEEEEEEEEEEEEEEEEE");
    }



    private void OnEnable() {
     controle.Gameplay.Enable();
    }
    private void OnDisable() {
    controle.Gameplay.Disable();
    }
}
