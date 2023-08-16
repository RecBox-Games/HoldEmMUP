using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cardController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = "1";
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeCardNumber(int newNum)
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = newNum.ToString();
    }
}
