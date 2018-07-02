using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Detta script sätts på Canvas. Detta gör så att du kan se hur mycket liv du har kvar på skärmen samt hur många mynd du plockat upp.

public class ScreenInfo : MonoBehaviour {

    [Header("Player Scripts")]
    //Dessa två håller reda på vilka objet som ska stå på skärmen. 

    [HideInInspector] public PlayerBag bag;   

    [Header("Screen Items")]
    //Dessa två håller reda på att det ska stå en text på skärmen när spelet startar.  
    public Text coinText;

	void Awake()
	{
		// Hämta referenser

		bag = FindObjectOfType<PlayerBag>();
	}

	void Update () {

	    coinText.text = "Coins: " + bag.coinCounter;
    }

}
