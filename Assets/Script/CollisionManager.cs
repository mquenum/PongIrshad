using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionManager : MonoBehaviour
{
    public UnityEvent triggerEntered;

    private void OnCollisionEnter(Collision collision)
    {

        triggerEntered.Invoke();
    }
}
