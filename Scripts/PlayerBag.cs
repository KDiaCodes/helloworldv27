using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Detta skript håller koll på alla objekt som spelaren kan interagera med.

public class PlayerBag : MonoBehaviour
{
	
	public bool hasKey; // true/false om spelaren har plockat upp nyckeln eller inte.

	public int coinCounter; // En mynträknare

	void Start()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "firstCoin"){
			coinCounter++;
			Destroy (other.gameObject);
		}
		if(other.tag == "secondCoin"){
			coinCounter++;
			Destroy (other.gameObject);
			SceneManager.LoadScene("Level2", LoadSceneMode.Single);
		}


		// Om vi plockar upp vinnar-myntet...
		if (other.tag == "WinnerCoin")
		{
			coinCounter++;

			// Sätt igång vinn skärmen
			VictoryScreen.Show();
		}
	}
}
