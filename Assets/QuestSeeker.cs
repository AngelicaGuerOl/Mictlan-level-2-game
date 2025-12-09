using UnityEngine;
using TMPro;
public class QuestSeeker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool hasQuestItem = false;
    public int coins = 0;
    public TMP_Text CoinText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.SetText("Coins: " + coins);
    }
}
