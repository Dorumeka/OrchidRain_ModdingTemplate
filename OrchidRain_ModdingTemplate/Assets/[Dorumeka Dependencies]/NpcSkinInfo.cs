using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSkinInfo : MonoBehaviour {
	[Space(5f)]
	[Header("Main Renderer")]
	public SkinnedMeshRenderer lod1;
	public SkinnedMeshRenderer lod2;
	public SkinnedMeshRenderer lod3;

	[Space(5f)]
	[Header("Accessories")]
	public Accessory[] accessories;
	public BoneAccessory[] boneAccessories;

	[Space(5f)]
	[Header("Materials")]
	public int skinIndex = 0;
	public Material[] possibleMaterials;
	public TextureSwapping[] textureSwappings;
	public TextureSwapping vanillaBootTextureSwapping;

	[Space(5f)]
	[Header("Other")]
	//public NpcAsset npcInfo;
	public GibsDictionary gibs;
	public NpcAppearanceStats appearanceStats;
	public NpcAudioClips audioClips;
	public bool needsHair;
	public bool needsEyes;
	//public GameObject[] gibSets;
}

[System.Serializable]
public struct Accessory {
	public SkinnedMeshRenderer accessory;
	public BoneType boneType;
}

[System.Serializable]
public struct BoneAccessory {
	public GameObject accessoryGameObject;
	public BoneType boneType;
}

[System.Serializable]
public struct TextureSwapping {
	public Texture2D diffuse;
	public Texture2D normalMap;
}