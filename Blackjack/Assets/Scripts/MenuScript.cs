using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public static int Money = 0;

    public GameObject MenuScreen;
    public GameObject PlayScreen;

    public AudioSource ButtonClick;
    public AudioSource CardClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            MenuScreen.SetActive(true);
            PlayScreen.SetActive(false);
        }

    }

    public void OnClickPlay()
    {
        MenuScreen.SetActive(false);
        PlayScreen.SetActive(true);
    }

    public void OnClickButtonSound()
    {
        ButtonClick.Play();
    }

    public void OnClickCardSound()
    {
        CardClick.Play();
    }
    

}
