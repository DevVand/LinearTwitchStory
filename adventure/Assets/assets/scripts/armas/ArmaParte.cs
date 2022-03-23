using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaParte : MonoBehaviour
{
    [SerializeField]
    Transform proximaParte;

    [SerializeField]
    public List<Adjetivo> adjetivos = new List<Adjetivo>();
    void Start()
    {
        
    }
    public ArmaParte getProximaParte() {
        return proximaParte != null? proximaParte.GetChild(0).GetComponent<ArmaParte>() : null;
    }
}
