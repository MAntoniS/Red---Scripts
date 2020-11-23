using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTauntText : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update


    public void setText(string tauntText) 
    {
        text.text = tauntText;
    }
}
