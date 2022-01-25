using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparkle : MonoBehaviour
{

    public Transform particleSpark;


     void Start()
    {
        particleSpark.GetComponent<ParticleSystem>().enableEmission = false;
    }

    void OnTriggerEnter(Collider other)
    {
            Collect();
       
    }

    public void Collect()
    {
        particleSpark.GetComponent<ParticleSystem>().enableEmission = true;
        StartCoroutine(stopParticles());
    }

    IEnumerator stopParticles()
    {
        yield return new WaitForSeconds(.4f);
        particleSpark.GetComponent<ParticleSystem>().enableEmission = false;
    }
}
