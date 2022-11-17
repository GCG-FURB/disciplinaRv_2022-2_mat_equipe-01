using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carregamento : MonoBehaviour
{
    public Material inicial;
    public Material alterado;
    private Renderer myRenderer;
    private bool alterar = true;
    private bool malOlhado = false;
    private int contador = 0;
    public Image ima = null;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        ima.enabled = false;
    }

    public void OnPointerEnter()
    {
        malOlhado = true;
        ima.enabled = true;
    }

    public void OnPointerExit()
    {
        malOlhado = false;
        contador = 0;
        myRenderer.material = inicial;
        ima.enabled = false;
    }

    void Update()
    {
        if(malOlhado && contador <= 100){
            contador += 1;
        }
        if(contador == 99){
            myRenderer.material = alterado;
            malOlhado = false;
            contador = 0;
        }
        ima.fillAmount = contador * 0.01f;
    }
}
