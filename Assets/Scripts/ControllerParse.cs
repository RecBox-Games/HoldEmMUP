using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerParse: MonoBehaviour
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

    public void MessageParse(string client, string msg)
    {
        PlayerInfo currentPlayer = null;

        if(client == "0x1-0")
        {
            currentPlayer = Player1;
        }
        else if(client == "0x1-1")
        {
            currentPlayer = Player2;

        }
        else if(client == "0x1-2")
        {
            currentPlayer = Player3;

        }
        else if(client == "0x1-3")
        {
            currentPlayer = Player4;
        }


        if(msg.Contains("NewPlayer("))
        {
            UpdatePlayer(client,msg,currentPlayer);
            
        }

        else if(msg.Contains("PlayerColor("))
        {
            UpdateColor(client,msg,currentPlayer);
        }

        else if (msg.Contains("UpdateNumber("))
        {
            UpdateNumber(client,msg,currentPlayer);
        }

        else if (msg.Contains("RequestGameState("))
        {
            RequestGameState(client, msg, currentPlayer);
            
        }

    }

    public void UpdatePlayer(string client, string msg, PlayerInfo CurrentPlayer)
    {
        string playerName =  msg.Substring(10, msg.Length-11);
        CurrentPlayer.playerName = playerName;
        CurrentPlayer.gameStarted = 1;
        controlpads_glue.SendControlpadMessage(client, playerName);

    }

    public void UpdateColor(string client, string msg, PlayerInfo CurrentPlayer)
    {
        string playerColor = msg.Substring(12, msg.Length-13);
        int colorCode = 0;
        if (playerColor == "green")
        {
            colorCode = 1;
        }
        else if (playerColor == "blue")
        {
            colorCode = 2;
        }
        else if (playerColor == "yellow")
        {
            colorCode = 3;
        }
        CurrentPlayer.playerColor = colorCode;
    }

        public void UpdateNumber(string client, string msg, PlayerInfo CurrentPlayer)
    {
        string playerNumber = msg.Substring(13, msg.Length-14);

        CurrentPlayer.playerNumber = playerNumber;
    }

      public void RequestGameState(string client, string msg, PlayerInfo CurrentPlayer)
    {
        string gamestate = "RequestGameState(" + CurrentPlayer.gameStarted + "," + CurrentPlayer.playerName + "," + CurrentPlayer.playerColor +")";
        controlpads_glue.SendControlpadMessage(client, gamestate);

    }



}
        


