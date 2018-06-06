using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum item
{
    Torch,
    Locket,
    Bag,
    Food,
    Water,
    Crowbar,
    Coat

}

public class PickupItem : MonoBehaviour {

    public item itemToPickup;
    private int index;
    private bool bagPickUp;
    public string textToDisplay;
	// Use this for initialization
	void Start ()
    {
        /*bagPickUp = false;

        if (itemToPickup == item.Locket)
        {
            index = 1;
        }
        else if (itemToPickup == item.Bag)
        {
            index = 2;
        }
        else if (itemToPickup == item.Torch)
        {
            index = 3;
        }
        else if (itemToPickup == item.Coat)
        {
            index = 4;
        }
        else if (itemToPickup == item.Water)
        {
            index = 5;
        }
        else if (itemToPickup == item.Food)
        {
            index = 6;
        }
        else if (itemToPickup == item.Crowbar)
        {
            index = 7;
        }
        else
        {
            return;
        }*/
	}
	
	public item Item()
    {
        return itemToPickup;
    }

    public string TextToDisplay()
    {
        return textToDisplay; 
    } 
}
