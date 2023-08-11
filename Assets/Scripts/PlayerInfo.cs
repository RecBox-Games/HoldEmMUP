using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{

    [SerializeField] Object playmat;
    [SerializeField] List<Material> materials = new List<Material>();
    public int playerColor;
    
    public Text PlayerName;
    public string playerName;
    public Text PlayerNumber;
    public string playerNumber;
    public int gameStarted;


    // Start is called before the first frame update
    void Start()
    {
        playerName = "Waiting to Join";
        playerNumber = "100";
        gameStarted = 0;
        playerColor = 4;

    }
    // Update is called once per frame
    void Update()
    {
        PlayerName.text = playerName;
        PlayerNumber.text = playerNumber;
    }

    // This function will return the Material color code 0-3
    public Material getMaterial()
    {
        return materials[playerColor];
    }

}
