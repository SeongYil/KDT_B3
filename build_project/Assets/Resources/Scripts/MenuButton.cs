using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickMeue()
    {
        UnityEngine.Debug.Log("Menu Click");

        Assets.Resources.Scripts.GameManager.instance.MenuBoardObj.SetActive(true);

    }
}
