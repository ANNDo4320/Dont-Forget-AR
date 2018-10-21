using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SubMenuManager : MonoBehaviour {
    public GameObject Submenu;
    public Image ButtonImage;
    public Sprite Down;
    public Sprite Up;
    // Use this for initialization
    void Start () {
		
	}
	public void ClickedSubMenuButton()
    {
        if(Submenu.activeSelf == false)
        {
            Submenu.SetActive(true);
            ButtonImage.sprite = Down;
        }
        else
        {
            Submenu.SetActive(false);
            ButtonImage.sprite = Up;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
