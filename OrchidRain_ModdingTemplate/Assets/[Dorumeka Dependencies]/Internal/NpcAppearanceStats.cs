using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NpcAppearanceStats", menuName = "Game Stats/Npc Appearance Stats")]
public class NpcAppearanceStats : ScriptableObject {
	public float minScale = 0.8325f;
	public float maxScale = 0.9675f;
	public float minBoobSize = 0.35f;
	public float maxBoobSize = 1.6f;
	public float minButtSize = 0.6f;
	public float maxButtSize = 1.75f;
}
