using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
	public Island[] islands;
	public Storage storage;
	public Fade fade;

	public void get(int i) {
		Island current = islands[i];
		if (current.isBoutght == false){
			if (storage.Coins >= current.cost){
				current.isBoutght = true;
				Debug.Log("Куплено");
				storage.Coins = storage.Coins - current.cost;
				islands[i] = current;
			} else {
				Debug.Log("Не хватает денег");
			}
		} else {
			Debug.Log("Ты уже давно это купил");
		}
	}

	public void Enter(int i){
		if(islands[i].isBoutght == true){
			storage.island = i;
			fade.FadeToLevel();
		}
	}
}
