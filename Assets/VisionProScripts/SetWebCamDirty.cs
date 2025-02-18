using UnityEngine;
using Unity.PolySpatial;
using UnityEngine.UI;

//https://docs.unity3d.com/Packages/com.unity.polyspatial.visionos@2.1/manual/WebCamTextures.html
public class SetWebCamDirty : MonoBehaviour
{
    [SerializeField] private RawImage rawImage; 
#if POLYSPATIAL_ENABLE_WEBCAM    
    public WebCamTexture texture;
#endif

    void Update()
    {
#if POLYSPATIAL_ENABLE_WEBCAM        
        // Texture may be null if the web camera isn't actively recording
        // into it.
        if (texture != null &&  texture.isPlaying)
            Unity.PolySpatial.PolySpatialObjectUtils.MarkDirty(texture);

        rawImage.texture = texture;
#endif            
    }
}