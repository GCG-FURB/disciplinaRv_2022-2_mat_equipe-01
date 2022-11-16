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

  private void Awake() {
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
   // audioS.playOneShot();
    
  }

  private void OnEnable() {
     controle.Gameplay.Enable();
  }
  private void OnDisable() {
    controle.Gameplay.Disable();
  }
}
