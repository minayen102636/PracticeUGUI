using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Core : MonoBehaviour
{

    //介面元件
    public Text pname;
    public Image portrait;
    public Text price;

    public void Change()
    {
        pname.text = "Caught";
        price.text = "0";
        portrait.sprite = Resources.Load<Sprite>("Person");
    }
}
