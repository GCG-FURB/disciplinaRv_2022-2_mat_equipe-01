using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Treasure : MonoBehaviour
{
    public Image imagem;
  ComtroleJogador controle;

  private void Awake() {
    Debug.Log("Ola mundao");
    controle = new ComtroleJogador();

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
