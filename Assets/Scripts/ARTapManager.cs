using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ARTapManager : MonoBehaviour {
    public GameObject EquipmentPanel;
    public TextMeshProUGUI PanelName;
    public TextMeshProUGUI PanelWeight;
    public TextMeshProUGUI PanelDescription;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
                if (raycastHit.collider.name == "Soccer")
                {
                    Debug.Log("Soccer Ball clicked");
                }

                //OR with Tag

                if (raycastHit.collider.CompareTag("Equipment"))
                {
                    EquipmentPanel.SetActive(true);
                    PanelName.text = raycastHit.collider.gameObject.GetComponent<EquipmentScript>().EquName;
                    PanelWeight.text = raycastHit.collider.gameObject.GetComponent<EquipmentScript>().EquWeight;
                    PanelDescription.text = raycastHit.collider.gameObject.GetComponent<EquipmentScript>().EquDescription;
                }
            }
        }
    }
}
