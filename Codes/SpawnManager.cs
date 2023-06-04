using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] hayvanlar;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnHayvanlar",5,1);
        //ilki ismi , oyun basladıktan ne kadar sonra baslasın , ne kadar surede spawn olsunlar yanı 2 sanıyede bır
    }

    // Update is called once per frame
    void Update()
    {
    //SpawnHayvanlar();
    }

    void SpawnHayvanlar()
    {
        int hayvanIndis = Random.Range(0, hayvanlar.Length);
        int xPos = Random.Range(-10, 10);
        Instantiate(hayvanlar[hayvanIndis], new Vector3(xPos, 0, 25), hayvanlar[hayvanIndis].transform.rotation);
        //hayvanların rastgele spawn olması için burada x eksenıne dıkkat etmek lazım

    }
}
