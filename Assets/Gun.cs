using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Instantiate_Position;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Born",0,5);
    }

    // Update is called once per frame
    void Update()
    {
        
        


        
    }
    public void Born()
    {
        Instantiate(Bullet, Instantiate_Position.transform.position,Instantiate_Position.transform.rotation);
    }
}
