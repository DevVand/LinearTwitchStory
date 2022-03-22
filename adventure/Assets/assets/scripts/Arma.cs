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
        pegarArma();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void removeFixo(Adjetivo adjetivo) {
        if (preAdj.Contains(adjetivo)) {
            preAdj.Remove(adjetivo);
        }
        else if (posAdj.Contains(adjetivo))
        {
            preAdj.Remove(adjetivo);
        }
    }
    void addFixo(Adjetivo adjetivo) {
        if (adjetivo.fixo < 0)
        {
            preAdj.Add(adjetivo);
        }
        else if (adjetivo.fixo > 0)
        {
            posAdj.Add(adjetivo);
        }
        else
        {
            if (Random.value > .5f) preAdj.Add(adjetivo); else posAdj.Add(adjetivo);
        }
    }
    void pegarArma() {
        Transform actual = transform;
            while (actual!=null)
            {
                try { 
                    actual = actual.transform.GetChild(0);
                    Adjetivo adjetivo = actual.GetComponent<Adjetivo>();
                if (adjetivo != null)
                    if (adjetivo.fixo < 0)
                    {
                        preAdj.Add(adjetivo);
                    }
                    else if (adjetivo.fixo > 0)
                    {
                        posAdj.Add(adjetivo);
                    }
                    else
                    {
                        if (Random.value > .5f) preAdj.Add(adjetivo); else posAdj.Add(adjetivo);
                    }
                }
                catch {
                    
                }
                
            }
    }
}
