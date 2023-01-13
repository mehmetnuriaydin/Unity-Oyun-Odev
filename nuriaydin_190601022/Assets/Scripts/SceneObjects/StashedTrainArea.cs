using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StashedTrainArea : MonoBehaviour
{
    //public UnlockData unlockableData;
    public TextMeshPro NameText;
    public TextMeshPro PriceText;
    //public List<GameObject> ObjectsToUnlock = new List<GameObject>();
    //public string unlockableName;

    //public int price;
    //public int RemainingPrice => price - CollectedPrice;
    public static int CollectedPrice;


    /*private void OnEnable()
    {
        CheckUnlocked();
    }*/


    void Start()
    {
        PriceText.text = CollectedPrice.ToString();
    }

    public void Pay(Stashable stashable)
    {       

        CollectedPrice++;
        stashable.PayStashable(transform, PaymentCompleted);

    }

    private void PaymentCompleted()
    {
        PriceText.text = CollectedPrice.ToString();

        //CheckUnlocked();
    }

    /*private void CheckUnlocked()
    {
        if (unlockableData.RemainingPrice <= 0)
        {
            ObjectsToUnlock.ForEach((x) =>
            {
                x.transform.parent = null;
                x.SetActive(true);
            });

            gameObject.SetActive(false);
        }
    }*/
}




