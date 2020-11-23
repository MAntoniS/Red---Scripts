using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taunt : MonoBehaviour
{

    string taunt;
    GameObject textPrefab;
    
    public string TauntPlayer { get => taunt; set => taunt = value; }
    public GameObject TextPrefab { get => textPrefab; set => textPrefab = value; }

    // Update is called once per frame
    public void tauntPlayer() 
    {
        GameObject text = Instantiate(TextPrefab, transform.position,Quaternion.identity);
        DisplayTauntText display = text.GetComponentInChildren<DisplayTauntText>();
        display.setText(taunt);
        Debug.Log("=========>" +taunt);
    }


}
