using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaymatController : MonoBehaviour
{
    [SerializeField] PlayerInfo playerInfo;
    [SerializeField] Material material;    

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        material = playerInfo.getMaterial();
        gameObject.GetComponent<Renderer>().material = material;
    }
}
