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
	[Key(0)] public List<bool> childDoorsEnabled;
	[Key(1)] public List<bool> childShadowCastersEnabled;
	[Key(2)] public List<bool> childLightsEnabled;
	[Key(3)] public List<bool> childSpriteRenderersEnabled;
}