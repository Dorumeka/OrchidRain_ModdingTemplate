using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibSkinInfo : MonoBehaviour {
	[Space(5f)]
	[Header("Main Renderer")]
	public SkinnedMeshRenderer lod1;
	public SkinnedMeshRenderer lod2;
	public SkinnedMeshRenderer lod3;
	//public SkinnedMeshRenderer eyes;

	[Space(5f)]
	[Header("Accessories")]
	public Accessory[] accessories;
	public BoneAccessory[] boneAccessories;
	//public Transform[] headbone;

	[ContextMenu("GetSingleRenderer()")]
	public void GetSingleRenderer () {
		lod1 = GetComponentInChildren<SkinnedMeshRenderer>();
	}

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
