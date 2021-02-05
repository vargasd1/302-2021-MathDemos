using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlanetMaterial : MonoBehaviour
{
    public int size = 512;
    private MeshRenderer mesh;
    public float zoom = 20;


    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        makeTexture();
    }

    void makeTexture()
    {
        Texture2D texture = new Texture2D(size, size);

        Color [] pixels = texture.GetPixels();

        for(int y = 0; y < size; y++)
        {
            for(int x = 0; x <size; x++)
            {
                int i = x + y * size;

                float a = Mathf.PerlinNoise(x/zoom, y/zoom);

                if(a < .5f)
                {
                    pixels[i] = new Color(0, 0, 225); // blue
                }
                else
                {
                    pixels[i] = new Color(0, 255, 0); // blue
                }

                
            }
        }
        texture.SetPixels(pixels);
        texture.Apply();



        mesh.material.SetTexture("_MainTex", texture);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
