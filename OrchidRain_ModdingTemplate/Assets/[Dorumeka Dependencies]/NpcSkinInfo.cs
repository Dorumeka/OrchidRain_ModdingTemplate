using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSkinInfo : MonoBehaviour {
	[Space(5f)]
	[Header("Main Renderer")]
	[Tooltip("GameObject containing your main Skinned Mesh Renderer. In case you don't have LODs set up, this is the only Lod field you need to fill.")]
	public SkinnedMeshRenderer lod1;
	[Tooltip("GameObject containing the Skinned Mesh Renderer of your level01 LOD.")]
	public SkinnedMeshRenderer lod2;
	[Tooltip("GameObject containing the Skinned Mesh Renderer of your level02 LOD.")]
	public SkinnedMeshRenderer lod3;

	[Space(5f)]
	[Header("Accessories")]
	[Tooltip("An Accessory is basically a clothing item. It's a skinned 3D model.")]
	public Accessory[] accessories;
	[Tooltip("A simpler version of an Accessory. A basic 3D model that will be linked to a bone. Something like a helmet, for example.")]
	public BoneAccessory[] boneAccessories;

	[Space(5f)]
	[Header("Materials")]
	[Tooltip("Leave this at 0")]
	public int skinIndex = 0;
	[Tooltip("In case you want your model to have a number materials/textures. Skin tones, for example. If you have 3 materials here, each of those will have a 33% chance to be on your model when spawned.")]
	public Material[] possibleMaterials;
	[Tooltip("If you just want to replace the vanilla texture of a game model, put your replacements here.")]
	public TextureSwapping[] textureSwappings;
	[Tooltip("You might also want to replace the boot's texures to complete your redesign.")]
	public TextureSwapping vanillaBootTextureSwapping;

	[Space(5f)]
	[Header("Other")]
	//public NpcAsset npcInfo;
	[Tooltip("Collection of your custom gibs.")]
	public GibsDictionary gibs;
	[Tooltip("Here you can override the NPCs vanilla proportions. Can be usefull if you want to make clothing and don't want the boobs to be so big they poke through.")]
	public NpcAppearanceStats appearanceStats;
	[Tooltip("Collection of custom audio clips.")]
	public NpcAudioClips audioClips;
	[Tooltip("Should be unchecked if: your custom model has its own hair or you want to make a head accessory like a helmet.\n\n" + "Should be checked if: you plan on modding a vanilla model and don't want to alter its head appearance.")]
	public bool needsHair = true;
	[Tooltip("Should be unchecked if: basically if you're replacing a vanilla model with anything.\n\n" + "Should be checked if: the mod is meant to be used with a vanilla model.")]
	public bool needsEyes = true;
	//public GameObject[] gibSets;

	[ContextMenu("GetLodRenderers")]
	public void GetLodRenderers () {
		LODGroup lod = GetComponentInChildren<LODGroup>();
		Transform lod1parent = lod.transform.GetChild(0).Find("Level00");
		if (lod1parent) lod1 = lod1parent.GetComponentInChildren<SkinnedMeshRenderer>();
		Transform lod2parent = lod.transform.GetChild(0).Find("Level01");
		if (lod2parent) lod2 = lod2parent.GetComponentInChildren<SkinnedMeshRenderer>();
		Transform lod3parent = lod.transform.GetChild(0).Find("Level02");
		if (lod3parent) lod3 = lod3parent.GetComponentInChildren<SkinnedMeshRenderer>();
	}
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