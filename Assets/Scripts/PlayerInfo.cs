using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{

    [SerializeField]
    public Text PlayerName;
    public string playerName;

        // Start is called before the first frame update
    void Start()
    {
        playerName = "Waiting to Join";
    }
    // Update is called once per frame
    void Update()
    {
      PlayerName.text = playerName;
    }

}
