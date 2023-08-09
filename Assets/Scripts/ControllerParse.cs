using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript: MonoBehaviour
{
    [SerializeField]
    public PlayerInfo Player1;
    public PlayerInfo Player2;
    public PlayerInfo Player3;
    public PlayerInfo Player4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newPlayer(string client, string msg)
    {
        if(msg.Contains("NewPlayer("))
        {
            string playerName = msg;
            playerName =  msg.Substring(10, msg.Length-11);

            if(client == "0x1-0")
            {
                Player1.playerName = playerName;
            }
            else if(client == "0x1-1")
            {
                Player2.playerName = playerName;

            }
            else if(client == "0x1-2")
            {
                Player3.playerName = playerName;

            }
            else if(client == "0x1-3")
            {
                Player4.playerName = playerName;

            }
            else
            {
                playerName = "Lobby is full";
            }

            controlpads_glue.SendControlpadMessage(client, playerName);
        }

    }
        

}
