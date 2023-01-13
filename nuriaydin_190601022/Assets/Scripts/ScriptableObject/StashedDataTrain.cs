using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Stashed Data Train", menuName = "ScriptableObjects/StashedDataTrain", order = 1)]
public class StashedDataTrain : ScriptableObject
{
    private const string UNLOCK_PLAYERPREF_KEY = "UNLOCK_PLAYERPREF_KEY:";
    public string stashableName;

    public int price;
    public int RemainingPrice => price - CollectedPrice;
    public int CollectedPrice
    {
        get => PlayerPrefs.GetInt(UNLOCK_PLAYERPREF_KEY + stashableName, 0);
        set => PlayerPrefs.SetInt(UNLOCK_PLAYERPREF_KEY + stashableName, value);
    }

}
