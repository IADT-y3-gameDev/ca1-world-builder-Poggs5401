using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
        public Transform teleportTarget;
        public GameObject thePlayer;    

        void onTriggerEnter(Collider other){
            thePlayer.transform.position = teleportTarget.transform.position;
        }
}
