using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTake : MonoBehaviour
{
    public GameObject prefab;
    public Transform parent;
    public static int cardNum = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            CardGiver();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    

    public void CardGiver()
    {
        Restart.remove = false;
    
        if (cardNum <= 10)
        {

            Instantiate(prefab, new Vector3(cardNum*175f, 200, 0), Quaternion.identity, parent);
            cardNum++;
        }
        
    }
}
