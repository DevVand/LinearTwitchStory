using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public string nome = "ARMA";

    List<Adjetivo> preAdj;
    List<Adjetivo> posAdj;
    void Start()
    {
        preAdj = new List<Adjetivo>();
        posAdj = new List<Adjetivo>();
        getArma();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void removeAdjetivo(Adjetivo adjetivo) {
        if (preAdj.Contains(adjetivo)) {
            preAdj.Remove(adjetivo);
        }
        else if (posAdj.Contains(adjetivo))
        {
            preAdj.Remove(adjetivo);
        }
    }
    void addAdjetivo(Adjetivo adjetivo) {
        if (adjetivo.posicao < 0)
        {
            preAdj.Add(adjetivo);
        }
        else if (adjetivo.posicao > 0)
        {
            posAdj.Add(adjetivo);
        }
        else
        {
            if (Random.value > .5f) preAdj.Add(adjetivo); else posAdj.Add(adjetivo);
        }
    }
    bool getArma() {
        ArmaParte armaParte = null;
        try
        {
            armaParte = transform.GetChild(0).GetComponent<ArmaParte>();
        }
        catch
        {
            return false;
        }
        while (armaParte != null)
        {
            foreach (Adjetivo adjetivo in armaParte.adjetivos)
            {
                if(Random.value<=adjetivo.chance)
                    addAdjetivo(adjetivo);
            }
            armaParte = armaParte.getProximaParte();
        }
        return true;
    }
}
