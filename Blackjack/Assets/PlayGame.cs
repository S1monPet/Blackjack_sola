using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayGame : MonoBehaviour
{
    public TextMeshProUGUI dealerDisp;
    public TextMeshProUGUI playerDisp;
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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Stay();
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
            win.SetActive(true); 
        }
        else if(playerCards == dealerCards && playerCards <= 21)
        {
            draw.SetActive(true);
        }
        else{
            lose.SetActive(true);
        }
    }

    

}


