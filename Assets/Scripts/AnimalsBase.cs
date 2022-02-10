using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalsBase : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public abstract void Sound();

    public virtual void Move(Rigidbody body)
    {
        Debug.Log("LEts move!");
        var rand = Random.Range(0, 3);
        var eulerAngleVelocity = new Vector3(0, 25, 0);
        var eulerAngleVelocityLeft = new Vector3(0, -25, 0);

        switch (rand)
        {
            case 0:
                body.AddRelativeForce(Vector3.forward * 10, ForceMode.Impulse);
                Debug.Log("Fram");
                break;
            case 1:
                Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity);
                body.MoveRotation(body.rotation * deltaRotation);
                Debug.Log("Hoger");
                break;
            case 2:
                Quaternion deltaRotationleft = Quaternion.Euler(eulerAngleVelocityLeft);
                body.MoveRotation(body.rotation * deltaRotationleft);
                Debug.Log("Vanster");
                break;
            default:
                break;

        }




    }

}