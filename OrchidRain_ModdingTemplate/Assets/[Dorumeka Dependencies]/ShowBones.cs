using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

public class ShowBones : MonoBehaviour {
	[Space(5f)]
	[Header("Variables")]
	public SkinnedMeshRenderer renderer;
	public Transform[] bones;
	//public int numberOfBones;

	[ContextMenu("ShowBones()")]
	void Populate () {
		renderer = GetComponent<SkinnedMeshRenderer>();
		bones = renderer.bones;
		/*bones = new Transform[numberOfBones];
		for (int i = 0; i < bones.Length; i++) {
			if (renderer.bones[i]) bones[i] = renderer.bones[i];
		}
		renderer.bones = bones;*/
	}
}
