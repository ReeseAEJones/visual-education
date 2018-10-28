using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour {

    private TerrainData tData;
    private float[,,] splatmap;
	// Use this for initialization
	void Start () {
        tData = GetComponent<TerrainCollider>().terrainData;
        tData.alphamapResolution = 129;

        float timeStart = 0.027f;
        float timeSkip = 0.027f;
        float[] splatWeights = new float[3];
        float splatSum;
        for (int x = 0; x < 129; x++)
        {
            for (int z = 0; z < 129; z++)
            {
                splatWeights[0] = 0.4f;
                splatWeights[1] = Mathf.PerlinNoise(timeStart * x, timeSkip * z);
                splatWeights[2] = Mathf.PerlinNoise(timeStart * x, 0.1f * z);

                splatSum = Sum(splatWeights);
                for (int t = 0; t < 3; t++)
                {
                    splatWeights[t] /= splatSum;

                    splatmap[x, z, t] = splatWeights[t];
                }
            }
        }

        tData.SetAlphamaps(0, 0, splatmap);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private float Sum(float[] arr)
    {
        return arr[0] + arr[1] + arr[2];
    }
}
