using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder1 : MonoBehaviour
{
    AudioSource ad;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bamboo")
            ad.Play();
    }
}
