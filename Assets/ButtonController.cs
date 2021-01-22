using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;

    void Start(){
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(true);
        Button4.SetActive(true);
        Button5.SetActive(false);
    }

    public void click(){
        Button3.SetActive(false);
        Button1.SetActive(true);
        Button2.SetActive(true);
        Button4.SetActive(false);
        Button5.SetActive(true);
    } 

    public void back(){
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(true);
        Button4.SetActive(true);
        Button5.SetActive(false);
    }
}
