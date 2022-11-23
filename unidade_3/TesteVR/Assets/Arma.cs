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
    private bool isSelecionado;

  private void Awake() {
    isSelecionado = false;
    Debug.Log("Ola arma");
    controle = new ComtroleJogador();
    //audioS = GetComponent<AudioSource>();

    controle.Gameplay.AcionaArma.performed += ctx => Aumentar();
  }

  private void Aumentar()
  {
    Debug.Log("nao armao");
    this.transform.localScale *= 1.1f;

    audioS.PlayOneShot(soundTiro);
    //audioS.playOneShot();
    
  }

   public void SelecionaArma()
    {
        isSelecionado = true;
        Debug.Log("Tiro");
        Aumentar();
    }
    public void DesselecionaArma()
    {
        Debug.Log("Saiu da arma");
        isSelecionado = false;
    }
    public void OnPointerExit()
    {
        isSelecionado = false;
        Debug.Log("Saiu da arma 2");
    }



    private void OnEnable() {
     controle.Gameplay.Enable();
  }
  private void OnDisable() {
    controle.Gameplay.Disable();
  }
}
