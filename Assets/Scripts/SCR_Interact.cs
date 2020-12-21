using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Interact : MonoBehaviour
{
    SCR_InformationNode focus;

    // Update is called once per frame
    void Update()
    {
        ObjectCheck();
        if (Input.GetMouseButtonDown(0))
        {
            Click();
        }
    }

    public void ObjectCheck()
    {
        RaycastHit hit;
        Physics.Raycast(this.transform.position, transform.forward, out hit, 4f);
        if (hit.collider?.gameObject?.GetComponent<SCR_InformationNode>())
        {
            focus = hit.collider.gameObject.GetComponent<SCR_InformationNode>();
            SCR_UIManager.instance.Interactable("Information Node : " + focus.name);
        }
        else
        {
            SCR_UIManager.instance.Interactable("");
            SCR_UIManager.instance.Information("");
        }
    }
    public void Click()
    {
        SCR_UIManager.instance.Information(focus.information);
    }
}
