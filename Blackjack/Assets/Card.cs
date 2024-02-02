using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Card : MonoBehaviour
{
    public GameObject cardDispObject;
    public TextMeshProUGUI cardDisp;
    // Start is called before the first frame update
    void Start()
    {
        OnClickCard();
        cardDispObject.SetActive (false);
        int cardVal = Random.Range(2, 11);
        string dispVal = cardVal.ToString(); 
        cardDisp.text = dispVal;
        PlayGame.playerCards += cardVal;
        Debug.Log("Player:" + PlayGame.playerCards.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (Restart.remove){
            Destroy(gameObject);
        }
    }

    
    public GameObject cardB;
    public Sprite Img1;
    public GameObject CardImg;
    float rotationAmount = 1f;
    float delaySpeed = 0.000005f;

    int rot = 0;

    int move = 100;
    bool start = true;
    public void OnClickCard()
    {
        CardImg.GetComponent<Image>().sprite = Img1;

        if (start){
            start = false;
            StartCoroutine(SlowSpin());
        if(move < 3){
        // Moves an object up 2 units
        //transform.position += new Vector3(50, 0, 0);
        move++; 
        }
        
        }
        

    }



    IEnumerator SlowSpin(){
    float count = 0;
    while(count < 180){
        gameObject.transform.Rotate(new Vector3(0, rotationAmount, 0));
        if (count == 90){
            if (rot == 0 ){
                cardB.SetActive (false); 
                cardDispObject.SetActive (true);
                rot++;
                gameObject.transform.Rotate(new Vector3(0, 180, 0));
            }
            else
            {
                cardB.SetActive (true); 
                cardDispObject.SetActive (false);
                rot--;
                gameObject.transform.Rotate(new Vector3(0, 180, 0));
            }
        }
        count += rotationAmount;
        yield return new WaitForSeconds(delaySpeed);
        
    }
    start = true;
    
    
}
}
