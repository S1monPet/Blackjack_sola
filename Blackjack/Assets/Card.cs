using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float rotationAmount = .1f;
    float delaySpeed = 0.01f;

    int move = 0;
    public void OnClickCard()
    {
        StartCoroutine(SlowSpin());
        if(move < 3){
        // Moves an object up 2 units
        //transform.position += new Vector3(50, 0, 0);
        move++; 
        }
        

    }



    IEnumerator SlowSpin(){
    float count = 0;
    while(count <= 90){
        gameObject.transform.Rotate(new Vector3(0, rotationAmount, rotationAmount));
        count += rotationAmount;
        yield return new WaitForSeconds(delaySpeed);
    }
}
}
