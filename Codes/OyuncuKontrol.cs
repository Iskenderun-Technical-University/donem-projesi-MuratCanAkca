using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public GameObject elmaPrefab;
    public float hiz = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //**************************************************************

        float sagsol = Input.GetAxis("Horizontal");
        //transform.Translate(new Vector3(1,0,0)*sagsol);
        transform.Translate(Vector3.right * sagsol * hiz );
        //hareket ettirmek için

        //***********************************************************
        
        int sınır = 10;
        if (transform.position.x > sınır )
        {
            transform.position = new Vector3( sınır ,0,0) /*transform.position.x*/;
        }
        if (transform.position.x < -sınır) 
        {
            transform.position = new Vector3(-sınır, 0, 0);
        }
        //oyuncu hareketini sınırlamak için

        //******************************************************

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(elmaPrefab, transform.position, elmaPrefab.transform.rotation);
        }

        //bosluk tusuna elma atmayı atadık
        //***************************************************************

       

    }
}
