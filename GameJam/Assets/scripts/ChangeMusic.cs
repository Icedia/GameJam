
using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour
{

    private AudioSource source;
    

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
     //   InvokeRepeating ("MusicStart", 4);
      //  CancelInvoke();
        
    }

    void Update()
    {
        MusicStart();
    }


    
    void MusicStart()
    {
        source.Play();

    }
}