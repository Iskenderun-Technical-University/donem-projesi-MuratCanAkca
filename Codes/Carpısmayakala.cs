using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpısmayakala : MonoBehaviour
{
    
    


    
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    //özel bir metot overrıde edılerek yapılır asagıdakı gıbı
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }

   
}
