using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaymatController : MonoBehaviour
{
    [SerializeField] PlayerInfo playerInfo;
    [SerializeField] Material material;    
    // public Material material;
    public GameObject Object; 
    
    // Start is called before the first frame update
    void Start()
    {
        Object.GetComponent<MeshRenderer>().material = material;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
