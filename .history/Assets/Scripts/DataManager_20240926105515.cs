using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set;}
    public Text playerText;
    public int PlayerScore;

    [System.Serializable]
    class SaveData
    {
        public Text PlayerNameText;
        public int PlayerScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
