using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBlocksCenter : MonoBehaviour
{
    [SerializeField] GameObject pre_Block;
    [SerializeField] float[] pos = new float[3];

    int x = 3, y = 3, z = 3;
    int step = 2;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < x; i++)
        {
            for(int j = 0; j < z; j++)
            {
                for (int k = 0; k < y; k++)
                {
                    GameObject.Instantiate(pre_Block, new Vector3(pos[0]+i * step,pos[1]+ k * step,pos[2]+ j * step), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
