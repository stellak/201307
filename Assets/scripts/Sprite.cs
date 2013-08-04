using UnityEngine;
using System.Collections;

public class Sprite : MonoBehaviour {
	
	public Vector2 spriteTopLeft;
	public Vector2 spriteSize;
	public Material spriteMaterial;
	public float defCameraPixels = 768f;
	public SpriteOrientation spriteOrientation;
	
	protected Mesh mesh;
	protected MeshRenderer renderer;
	
	void Awake()
		
	{
		if (spriteMaterial == null||spriteMaterial.mainTexture == null)
		{Debug.LogError("should decide the material");
			return;
		}
		
	// Use this for initialization

	
	// Update is called once per frame

}
