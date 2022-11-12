using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Treasure : MonoBehaviour
{
  
  ComtroleJogador controle;

  private void Awake() {
    Debug.Log("Ola mundao");
    controle = new ComtroleJogador();

    controle.Gameplay.Aumentar.performed += ctx => Aumentar();
  }

  private void Aumentar()
  {
    Debug.Log("nao brocha");
    this.transform.localScale *= 1.1f;
  }

  private void OnEnable() {
     controle.Gameplay.Enable();
  }
  private void OnDisable() {
    controle.Gameplay.Disable();
  }
}
