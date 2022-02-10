using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : AnimalsBase
{
    private Rigidbody rosterRb;
    public override void Sound()
    {
        Debug.Log("KUKKKEEELIKUUUU");
    }

    // Start is called before the first frame update
    void Start()
    {
        rosterRb = GetComponent<Rigidbody>();
        InvokeRepeating("MoveRandom", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
       // base.Move(rosterRb);
    }

    void MoveRandom()
    {
        base.Move(rosterRb);
    }
}
