using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform targetPad;
    public GameObject theCharacter;

    // Update is called once per frame
    void Update()
    {
        script.con.enabled = true;
    }

    void OnTriggerEnter(Collider other){
        script.con.enabled = false;
        theCharacter.transform.position = targetPad.transform.position;
    }
}
