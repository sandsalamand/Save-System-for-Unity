using MessagePack;
using MessagePack.Resolvers;
using MessagePack.Unity;
using MessagePack.Unity.Extension;
using Serializer;
using ToolBox.Serialization;
using UnityEngine;

namespace MessagePackGenerator
{
	public static class MessagePackStartup
	{
		private static bool _serializerRegistered;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Initialize()
		{
			if (_serializerRegistered)
			{
				return;
			}

			StaticCompositeResolver.Instance.Register(
				//GeneratedResolver.Instance,
				UnityBlitResolver.Instance,
				UnityResolver.Instance,
				StandardResolver.Instance,
				DataSerializerResolver.Instance
			);

			var options = ContractlessStandardResolverAllowPrivate.Options.WithResolver(StaticCompositeResolver.Instance);

			DataSerializer.Options = options;
			MessagePackSerializer.DefaultOptions = options;

			_serializerRegistered = true;
		}
	}
}