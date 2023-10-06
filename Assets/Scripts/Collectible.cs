using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
   CollectibleCount script;
    public int total;

    void Awake(){
        script = GameObject.FindGameObjectWithTag("coinCount").GetComponent<CollectibleCount>();
    }

    void Update()
    {
        transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0);
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            script.count++;
            Destroy(gameObject);
        }
    }
}
