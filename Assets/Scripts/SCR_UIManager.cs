using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_UIManager : MonoBehaviour
{
    public static SCR_UIManager instance;

    public Text itemName;
    public Text information;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interactable(string name)
    {
        itemName.text = name;
    }
    public void Information(string _information)
    {
        information.text = _information;
    }

}
