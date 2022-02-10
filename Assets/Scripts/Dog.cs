using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : AnimalsBase
{
    private Rigidbody dogRb;
    public override void Sound()
    {
        Debug.Log("Sound is WOFF WOOOOFF");
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveRandom", 2f, 2f);
        dogRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void MoveRandom()
    {
        base.Move(dogRb);
    }



}
