public enum Ai_Weapon {
	Random,
	Unarmed,
	TR8_R,
	Makarov,
	MakarovSilenced,
	SMG,
	KSG
};

public enum PlayerWeapon {
	Unarmed,
	TR8_R,
	Dartgun,
	Makarov,
	MakarovSilenced,
	SMG,
	KSG
}

public enum PlayerItems {
	CovertModem,
	GenericDildo
}

public enum Ai_Type {
	Wander,
	Guard,
	Waypoints
};

public enum Waypoints_Behavior {
	OnceThenWander,
	OnceThenGuard,
	PingPong,
	StartOver,
	Random
};

public enum Doru_Type {
	NormalLow,
	NormalHigh,
	Naked,
	HalloweenLow,
	HalloweenHigh,
	Fizzil01a,
	Fizzil01b,
	Fizzil02,
	NekoDoru,
	Random
};

public enum Faction {
	BlueRainCorp,
	CruzInstitute,
	Monsters
};

public enum HitBoxType {
	Main,
	Body,
	Head,
	Arm_L,
	Arm_R,
	Leg_L,
	Leg_R,
	Player
};

public enum MissionObjectiveType {
	Assassinate,
	Protect,
	Interact,
	UseItem,
	Collect,
	Arrive,
	Destroy
};

public enum DropableItemType {
	MedPack_Small,
	MedPack_Medium
};

public enum DamageType {
	Ragdoll,
	Gibbing,
	Dismember_Slash,
	Dismember_Shot,
	PassOut,
	InstaGib
};

public enum CauseOfDeath {
	StabBody,
	StabFace,
	Faint,
	Ragdoll
};

public enum HurtType {
	Body_Shot,
	Hip_Shot,
	LegL_Shot,
	LegR_Shot,
	ArmL_Shot,
	ArmR_Shot,
	Head_Shot,
	Body_Slash
};

public enum UiEquipmentType {
	NonLethal,
	Lethal,
	ItemAmmo,
	ItemAmmoless
};

public enum BoneType {
	Pelvis,
	Spine0,
	L_Thigh,
	L_Calf,
	L_Foot,
	R_Thigh,
	R_Calf,
	R_Foot,
	Spine1,
	Spine2,
	L_UpperArm,
	L_LowerArm,
	L_Hand,
	R_UpperArm,
	R_LowerArm,
	R_Hand,
	Neck,
	Head
};

public enum GibType {
	Arm_L,
	Arm_R,
	HeadWhole,
	Leg_L,
	Leg_R,
	TorsoRipped,
	Pelvis,
	TorsoWhole,
	Legs,
	Half_L,
	Half_R
};

public enum GibSetType {
	AllRipped,
	Halves,
	LegsTorso,
	LowerRipped,
	UpperRipped
};

public enum VoiceClip {
	//Alive
	aIdle,
	aChat_Question,
	aChat_Answer,
	aStartled,
	aThreat,
	aHurt,
	aMeleeAttack,
	aTrouble,
	aSurrender,
	//Deaths
	dGeneric,
	dFaint,
	dFaint_Muffled,
	dViolent,
	dDismember_Arm,
	dDismember_Leg,
	dChoking,
	dDrowning,
	dMuffled,
	dCrazy,
	dFalling,
	//Sex
	sMumble,
	sMoan_Breathe,
	sMoan_Low,
	sMoan_High,
	sOrgasm
};

public enum DoruPersonality {
	Generic,
	Sensual,
	Shy
}