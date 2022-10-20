using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentateurScript : MonoBehaviour
{
    public  GameObject subPhrase;
    public GameObject variable;
    private AudioSource sub;
    private AudioSource var;

    private void Start()
    {
        sub = subPhrase.GetComponent<AudioSource>();
        var = variable.GetComponent<AudioSource>();
}
    private void OnTriggerEnter(Collider other)
    {
        sub.Play();
        while (!sub.isPlaying)
        {
           var.Play();
        }
        
        
        
    }
}
