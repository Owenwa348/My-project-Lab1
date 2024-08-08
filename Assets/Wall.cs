using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject block;
    public int width = 10;
    public int height = 4;
    void create_Wall(){
         for (int y=0; y<height; ++y)
        {
            for (int x=0; x<width; ++x)
            {
                Vector3 offset = new Vector3(x, y, 0);
                Instantiate(block, transform.position + offset, Quaternion.identity);
            }
        }
    }
    void Start() 
    
    {
        
        this.create_Wall(); 
        //  for (int y=0; y<height; ++y)
        // {
        //     for (int x=0; x<width; ++x)
        //     {
        //         Vector3 offset = new Vector3(x, y, 0);
        //         Instantiate(block, transform.position + offset, Quaternion.identity);
        //     }
        // }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
