using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{

    [SerializeField] Object playmat;
    [SerializeField] List<Material> materials = new List<Material>();
    [SerializeField] int playerColor;

    public Text PlayerName;
    public string playerName;
    

        // Start is called before the first frame update
    void Start()
    {
        playerName = "Waiting to Join";

        // This needs to be changed to how ever the server sends a players color over.
        playerColor = 1;


    }
    // Update is called once per frame
    void Update()
    {
        PlayerName.text = playerName;
        playmat.GetComponent<MeshRenderer>().material = materials[playerColor];

    }


}
