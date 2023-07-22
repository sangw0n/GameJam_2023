using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance{get; private set;}

    [Tooltip("플레이어 돈(Int)")]
    [SerializeField] Text goldText;
    public int playerMoney = 100;

    void Awake()
    {
        instance = this;
    }

    public void Die(){

    }

    private void Update() {
        goldText.text = new string(playerMoney + "");
    }
}
