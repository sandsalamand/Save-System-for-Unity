using MessagePack;
using System;
using System.Collections.Generic;

[MessagePackObject, Serializable]
public struct PlayerData
{
	[Key(0)] public UnityEngine.Vector3 position;
	[Key(1)] public float sanity;
}

[MessagePackObject, Serializable]
public struct DemonData
{
	[Key(0)] public UnityEngine.Vector3 position;
	[Key(1)] public int stateName;	//this gets converted back into an enum on load
}

[MessagePackObject, Serializable]
public struct RoomSaveData
{
	[Key(0)] public bool[] childShadowCastersEnabled;
	[Key(1)] public bool[] childLightsEnabled;
	[Key(2)] public bool[] childSpriteRenderersEnabled;
	[Key(3)] public bool[] childCollidersEnabled;
}

[MessagePackObject, Serializable]
public struct HouseLightsData
{
	[Key(0)] public bool[] lightsEnabled;
}