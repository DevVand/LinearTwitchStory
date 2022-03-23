using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debbuger : MonoBehaviour
{
    [SerializeField]
    Transform proximaParte;
    [SerializeField]
    GameObject obj;
    void Start()
    {
        print(proximaParte);
        print(proximaParte == transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1)) {
            GameObject o = Instantiate(obj);
            o.SetActive(false);
        }
    }
}
