using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    //When the bird passes thru the col it calls BirdScored in game control
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }


}
