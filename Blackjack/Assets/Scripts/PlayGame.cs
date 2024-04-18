using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayGame : MonoBehaviour
{
    int Money = 1000;
    public TextMeshProUGUI dealerDisp;
    public TextMeshProUGUI playerDisp;
    public TextMeshProUGUI pointDisp;
    public GameObject card;
    static public int dealerCards;
    static public int playerCards;
    int playerHis;
    public GameObject win;
    public GameObject lose;
    public GameObject draw;

    // Start is called before the first frame update
    void Start()
    {
        Money -= 100;
        UpdatePoints();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Stay();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("tu ni problem");
            Money -= 100;
            UpdatePoints();
        }

        if(playerHis != playerCards){
            playerDisp.text = "Player: " + playerCards.ToString();
            playerHis = playerCards;
        }
        if(playerCards == 0){
            dealerDisp.text = "Dealer: " + dealerCards.ToString();
        }
    }
    
    public void Stay()
    {
        
        while (dealerCards < playerCards && playerCards < 22 || dealerCards <= playerCards && playerCards < 13)
        {
            dealerCards += Random.Range(2, 11); 
        }
        dealerDisp.text = "Dealer: " + dealerCards.ToString();
        Debug.Log("dealer:" + dealerCards.ToString());

        if (playerCards > dealerCards && playerCards <= 21 || playerCards <= 21 && dealerCards > 21)
        {
            Money += 200;
            win.SetActive(true); 
        }
        else if(playerCards == dealerCards && playerCards <= 21)
        {
            Money += 100;
            draw.SetActive(true);
        }
        else{
            lose.SetActive(true);
        }
    }

    public void UpdatePoints()
    {
        pointDisp.text = "Points: " + Money.ToString();
    }

    public void RemovePoints()
    {
        Money -= 100;
        UpdatePoints();
    }

    

}


