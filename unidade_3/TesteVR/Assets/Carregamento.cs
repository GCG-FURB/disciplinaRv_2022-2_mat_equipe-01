using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carregamento : MonoBehaviour
{
    private static bool malOlhado = false;
    private static int contador = 0;
    public Image ima = null;
    private static int passo = 500;

    public bool teste = false;
    void Start()
    {
        ima.enabled = false;
    }

    public void EntraCarregamento()
    {
        Debug.Log("Entro Imagen");
        malOlhado = true;
        ima.enabled = true;
    }

    public void SaiCarregamento()
    {
        Debug.Log("Saio Imagen");
        malOlhado = false;
        contador = 0;
        ima.enabled = false;
    }

    void Update()
    {
        if(malOlhado && contador <= passo){
            contador += 1;
        }
        if(contador == passo){
            malOlhado = false;
            contador = 0;
        }
        ima.fillAmount = contador * (1f/passo);
    }
}
