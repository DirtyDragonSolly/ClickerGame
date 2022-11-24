using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{   
    private const string MONEY_VIEW = "$ "; 
    
    private decimal moneyCount;
    private Text moneyObjectText;

    public void GetMoney(decimal price) => moneyCount += price;
    private void Start()
    {
        moneyObjectText = GetComponent<Text>();
    }

    private void Update()
    {
        moneyObjectText.text = MONEY_VIEW + moneyCount.ToString();
    }
}
