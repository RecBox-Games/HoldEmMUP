using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void respond_with_color(string client, string msg) {
    string button_color = "";
	  if (msg == "select") {
        button_color = "green";
    } else if (msg == "back") {
        button_color = "red";
    } else {
        button_color = "yellow";
    }
	  controlpads_glue.SendControlpadMessage(client, button_color);
    }

}
