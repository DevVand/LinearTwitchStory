using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Adjetivo
{
    public string nome;
    public int posicao;
    public float chance;

    public Adjetivo(string nome = "ADJETIVO", int posicao = 0, float chance = 1) {
        this.nome = nome;
        this.posicao = posicao;
        this.chance = chance;
    }
}
