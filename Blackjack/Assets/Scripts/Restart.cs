using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject win;
    public GameObject lose;
    public GameObject draw;
    public static bool remove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    public void Reset()
    {
        remove = true;
        PlayGame.playerCards = 0;
        PlayGame.dealerCards = 0;
        CardTake.cardNum = 1;   
            win.SetActive (false); 
            lose.SetActive (false); 
            draw.SetActive(false);

    }
}
