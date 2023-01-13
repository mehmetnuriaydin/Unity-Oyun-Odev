using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Stash))]
public class TrainPayer : MonoBehaviour
{
    private Stash _stash;
    private float nextTimeToPay = 0;
    private float paymentDelay = 0.1f;
    private void Awake()
    {
        _stash = GetComponent<Stash>();
        nextTimeToPay = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_stash.CollectedCount <= 0)
            return;


        if (other.CompareTag("Unlockable"))
        {
            nextTimeToPay = Time.time + paymentDelay;

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (_stash.CollectedCount <= 0)
            return;


        if (other.CompareTag("Unlockable"))
        {
            if (Time.time < nextTimeToPay)
                return;

            nextTimeToPay = Time.time + paymentDelay;

            if (other.TryGetComponent(out StashedTrainArea unlockable))
            {
                StartPayment(unlockable);
            }
        }
    }

    private void StartPayment(StashedTrainArea unlockable)
    {
        

        var stashable = _stash.RemoveStash();
        if (stashable == null)
            return;

        unlockable.Pay(stashable);
    }
}
