using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float hiz = 0.0001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *hiz );
        //bağlandıkları nesnelere hareket kazandırır

        //**********************************************
        
        if (transform.position.z > 30)
        {
           
            Destroy(gameObject);
        }
        //elmaların mesafe dısına cıkınca yok olması
        //***************************************************

        if (transform.position.z < -30)
        {
           
            Destroy(gameObject);
        }
        //buda zombi için 
        //********************************

       
    }
}
