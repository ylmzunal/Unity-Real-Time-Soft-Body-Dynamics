using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step7 : MonoBehaviour
{
    // Public variables for different texture maps
    public Texture2D albedoMap;
    public Texture2D metallicMap;
    public Texture2D normalMap;
    public Texture2D roughnessMap;

    void Start()
    {
        // Create a new material
        Material material = new Material(Shader.Find("Standard"));

        // Assign textures to the material's properties
        if (albedoMap != null)
            material.SetTexture("_MainTex", albedoMap);

        if (metallicMap != null)
            material.SetTexture("_MetallicGlossMap", metallicMap);

        if (normalMap != null)
            material.SetTexture("_BumpMap", normalMap);

        if (roughnessMap != null)
            material.SetTexture("_SpecGlossMap", roughnessMap);

        // Get the Mesh Renderer component attached to this GameObject
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Assign the created material to the Mesh Renderer
        meshRenderer.material = material;
    }
}
