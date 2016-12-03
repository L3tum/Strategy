
using System;
using System.Collections.Generic;
using System.Reflection;
using SiliconStudio.Core.Serialization;
using SiliconStudio.Core.Reflection;
using SiliconStudio.Core.Serialization.Serializers;
using SiliconStudio.DataSerializers;

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETPortable,Version=v4.6,Profile=Profile151", FrameworkDisplayName=".NET Portable Subset")]

[assembly: SiliconStudio.Core.Serialization.Serializers.AssemblySerializerFactory(Type = typeof(SiliconStudio.DataSerializers.Strategy_GameSerializerFactory))]

namespace SiliconStudio.Core.Serialization.Serializers
{
	class AssemblySerializerFactoryAttribute : Attribute
	{
		public Type Type;
	}
}

namespace SiliconStudio.DataSerializers
{
    // Assembly attributes that defines supported serializer (only generics one so that other assemblies can do generic instantiations by themselves)
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_BasicCameraControllerSerializer), typeof(Strategy.BasicCameraController), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_BelieveSerializer), typeof(Strategy.Believe), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_CitySerializer), typeof(Strategy.City), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,System.Int32>), typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_City_ClassificationSerializer), typeof(Strategy.City_Classification), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_CountrySerializer), typeof(Strategy.Country), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.ListSerializer<System.Int32>), typeof(System.Collections.Generic.List<System.Int32>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_country_reign_formSerializer), typeof(Strategy.country_reign_form), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_GameManagerSerializer), typeof(Strategy.GameManager), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Population>), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Population>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_PopulationSerializer), typeof(Strategy.Population), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Country>), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Country>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Believe>), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Believe>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.State>), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.State>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_StateSerializer), typeof(Strategy.State), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Province>), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Province>), DataSerializerGenericMode.None, false, false, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_ProvinceSerializer), typeof(Strategy.Province), DataSerializerGenericMode.None, true, true, Profile = "Default")]
    [DataSerializerGlobalAttribute(typeof(SiliconStudio.DataSerializers.Strategy_ReligionSerializer), typeof(Strategy.Religion), DataSerializerGenericMode.None, true, true, Profile = "Default")]
   	public static class Strategy_GameSerializerFactory
	{
	    [SiliconStudio.Core.ModuleInitializer]
        internal static void Initialize()
        {
			var assemblySerializers = new AssemblySerializers(typeof(Strategy_GameSerializerFactory).GetTypeInfo().Assembly);

			// Register data contract aliases

			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_EngineSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Core_MathematicsSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_CoreSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_PhysicsSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_ParticlesSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_SpriteStudio_RuntimeSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_NativeSerializerFactory).GetTypeInfo().Module);
			assemblySerializers.Modules.Add(typeof(SiliconStudio.DataSerializers.SiliconStudio_Xenko_UISerializerFactory).GetTypeInfo().Module);

			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Default"] = assemblySerializersProfile;

				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x8ecbed72, 0x29961d9f, 0x7617bcde, 0x48ddcbbf), typeof(Strategy.BasicCameraController), typeof(SiliconStudio.DataSerializers.Strategy_BasicCameraControllerSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xda9eedc9, 0x763b3754, 0x1aba0f49, 0xfd437b97), typeof(Strategy.Believe), typeof(SiliconStudio.DataSerializers.Strategy_BelieveSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x65a63635, 0x905b96ce, 0x5fa716d9, 0x67302976), typeof(Strategy.City), typeof(SiliconStudio.DataSerializers.Strategy_CitySerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xa6f677d0, 0x0f6a25c4, 0x56c1dbd7, 0x70d216a3), typeof(System.Collections.Generic.Dictionary<System.Int32,System.Int32>), typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,System.Int32>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xdc943164, 0x20bcb78a, 0xf70ca33c, 0xf1fd3d6a), typeof(Strategy.City_Classification), typeof(SiliconStudio.DataSerializers.Strategy_City_ClassificationSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xa93b8fcb, 0x9809c426, 0x3a89a217, 0x4b079f7c), typeof(Strategy.Country), typeof(SiliconStudio.DataSerializers.Strategy_CountrySerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x3e3ca2b8, 0x17007a32, 0xa8a3b32f, 0x26e7f933), typeof(System.Collections.Generic.List<System.Int32>), typeof(SiliconStudio.Core.Serialization.Serializers.ListSerializer<System.Int32>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xec16c101, 0x148a775a, 0x4ab58eb2, 0x4c6bfa4d), typeof(Strategy.country_reign_form), typeof(SiliconStudio.DataSerializers.Strategy_country_reign_formSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x1dfc486b, 0xd61bfe58, 0x4e0d571a, 0x2a4deabf), typeof(Strategy.GameManager), typeof(SiliconStudio.DataSerializers.Strategy_GameManagerSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x736e9489, 0x057acd73, 0xf1f06ac1, 0x04cee503), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Population>), typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Population>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x6f744978, 0xf28745fb, 0x96b3d247, 0x06f11b9a), typeof(Strategy.Population), typeof(SiliconStudio.DataSerializers.Strategy_PopulationSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x386b93ec, 0xb58c77bd, 0x7393c4df, 0xc5d84cf2), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Country>), typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Country>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xdf6c3af2, 0x24e8bdaa, 0xa6f91ebf, 0x67389c06), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Believe>), typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Believe>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x764a2b01, 0x498771de, 0xf8b11b3b, 0x4b0c00ff), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.State>), typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.State>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xfb71cc71, 0xc716d0b7, 0x72b5948e, 0xb3c53064), typeof(Strategy.State), typeof(SiliconStudio.DataSerializers.Strategy_StateSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0xfb6b8fed, 0x28034bf3, 0x2c6d2465, 0xe27ec6fb), typeof(System.Collections.Generic.Dictionary<System.Int32,Strategy.Province>), typeof(SiliconStudio.Core.Serialization.Serializers.DictionarySerializer<System.Int32,Strategy.Province>)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x79983ce7, 0xa418e807, 0xd9b616f3, 0x6c9e7a2c), typeof(Strategy.Province), typeof(SiliconStudio.DataSerializers.Strategy_ProvinceSerializer)));
				assemblySerializersProfile.Add(new AssemblySerializerEntry(new SiliconStudio.Core.Storage.ObjectId(0x1834c528, 0x4428c4d7, 0x80fbc09a, 0xb103d274), typeof(Strategy.Religion), typeof(SiliconStudio.DataSerializers.Strategy_ReligionSerializer)));
			}
			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Content"] = assemblySerializersProfile;

			}
			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Hash"] = assemblySerializersProfile;

			}
			{
				var assemblySerializersProfile = new AssemblySerializersPerProfile();
				assemblySerializers.Profiles["Clone"] = assemblySerializersProfile;

			}

			DataSerializerFactory.RegisterSerializationAssembly(assemblySerializers);
            AssemblyRegistry.Register(typeof(Strategy_GameSerializerFactory).GetTypeInfo().Assembly, AssemblyCommonCategories.Engine);
        }
	}
}



namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_BasicCameraControllerSerializer : ClassDataSerializer<Strategy.BasicCameraController>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.SyncScript> parentSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Vector3> KeyboardMovementSpeedSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Vector3> TouchMovementSpeedSerializer;
		private DataSerializer<System.Single> SpeedFactorSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Vector2> KeyboardRotationSpeedSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Vector2> MouseRotationSpeedSerializer;
		private DataSerializer<SiliconStudio.Core.Mathematics.Vector2> TouchRotationSpeedSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.SyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.SyncScript"));
			// Cache member serializers
			KeyboardMovementSpeedSerializer = MemberSerializer<SiliconStudio.Core.Mathematics.Vector3>.Create(serializerSelector);
			SpeedFactorSerializer = MemberSerializer<System.Single>.Create(serializerSelector);
			KeyboardRotationSpeedSerializer = MemberSerializer<SiliconStudio.Core.Mathematics.Vector2>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.BasicCameraController obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.SyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.BasicCameraController)parentObj;

            SiliconStudio.Core.Mathematics.Vector3 keyboardMovementSpeed = mode == ArchiveMode.Serialize ? obj.KeyboardMovementSpeed : default(SiliconStudio.Core.Mathematics.Vector3);
            KeyboardMovementSpeedSerializer.Serialize(ref keyboardMovementSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.KeyboardMovementSpeed = keyboardMovementSpeed;
            SiliconStudio.Core.Mathematics.Vector3 touchMovementSpeed = mode == ArchiveMode.Serialize ? obj.TouchMovementSpeed : default(SiliconStudio.Core.Mathematics.Vector3);
            KeyboardMovementSpeedSerializer.Serialize(ref touchMovementSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.TouchMovementSpeed = touchMovementSpeed;
            System.Single speedFactor = mode == ArchiveMode.Serialize ? obj.SpeedFactor : default(System.Single);
            SpeedFactorSerializer.Serialize(ref speedFactor, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.SpeedFactor = speedFactor;
            SiliconStudio.Core.Mathematics.Vector2 keyboardRotationSpeed = mode == ArchiveMode.Serialize ? obj.KeyboardRotationSpeed : default(SiliconStudio.Core.Mathematics.Vector2);
            KeyboardRotationSpeedSerializer.Serialize(ref keyboardRotationSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.KeyboardRotationSpeed = keyboardRotationSpeed;
            SiliconStudio.Core.Mathematics.Vector2 mouseRotationSpeed = mode == ArchiveMode.Serialize ? obj.MouseRotationSpeed : default(SiliconStudio.Core.Mathematics.Vector2);
            KeyboardRotationSpeedSerializer.Serialize(ref mouseRotationSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.MouseRotationSpeed = mouseRotationSpeed;
            SiliconStudio.Core.Mathematics.Vector2 touchRotationSpeed = mode == ArchiveMode.Serialize ? obj.TouchRotationSpeed : default(SiliconStudio.Core.Mathematics.Vector2);
            KeyboardRotationSpeedSerializer.Serialize(ref touchRotationSpeed, mode, stream);
            if (mode == ArchiveMode.Deserialize)
                obj.TouchRotationSpeed = touchRotationSpeed;
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_BelieveSerializer : ClassDataSerializer<Strategy.Believe>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.String> nameSerializer;
		private DataSerializer<System.Int32> believe_idSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
			believe_idSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.Believe obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.Believe)parentObj;

            nameSerializer.Serialize(ref obj.name, mode, stream);
            believe_idSerializer.Serialize(ref obj.believe_id, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_CitySerializer : ClassDataSerializer<Strategy.City>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>> populationsSerializer;
		private DataSerializer<System.Int32> classificationSerializer;
		private DataSerializer<System.Int32> city_idSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			populationsSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>.Create(serializerSelector);
			classificationSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.City obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.City)parentObj;

            populationsSerializer.Serialize(ref obj.populations, mode, stream);
            classificationSerializer.Serialize(ref obj.classification, mode, stream);
            classificationSerializer.Serialize(ref obj.city_id, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_City_ClassificationSerializer : ClassDataSerializer<Strategy.City_Classification>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.Int32> pop_limitSerializer;
		private DataSerializer<System.String> nameSerializer;
		private DataSerializer<System.String> class_idSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			pop_limitSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
			nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.City_Classification obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.City_Classification)parentObj;

            pop_limitSerializer.Serialize(ref obj.pop_limit, mode, stream);
            nameSerializer.Serialize(ref obj.name, mode, stream);
            nameSerializer.Serialize(ref obj.class_id, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_CountrySerializer : ClassDataSerializer<Strategy.Country>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.String> country_nameSerializer;
		private DataSerializer<System.Int32> country_idSerializer;
		private DataSerializer<System.Collections.Generic.List<System.Int32>> statesSerializer;
		private DataSerializer<System.Collections.Generic.List<System.Int32>> provincesSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>> populationsSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			country_nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
			country_idSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
			statesSerializer = MemberSerializer<System.Collections.Generic.List<System.Int32>>.Create(serializerSelector);
			populationsSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.Country obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.Country)parentObj;

            country_nameSerializer.Serialize(ref obj.country_name, mode, stream);
            country_idSerializer.Serialize(ref obj.country_id, mode, stream);
            statesSerializer.Serialize(ref obj.states, mode, stream);
            statesSerializer.Serialize(ref obj.provinces, mode, stream);
            populationsSerializer.Serialize(ref obj.populations, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_country_reign_formSerializer : ClassDataSerializer<Strategy.country_reign_form>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.String> nameSerializer;
		private DataSerializer<System.String> form_idSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.country_reign_form obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.country_reign_form)parentObj;

            nameSerializer.Serialize(ref obj.name, mode, stream);
            nameSerializer.Serialize(ref obj.form_id, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_GameManagerSerializer : ClassDataSerializer<Strategy.GameManager>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.StartupScript> parentSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Population>> populationsSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Country>> countriesSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Believe>> believesSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.State>> statesSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Province>> provincesSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.StartupScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.StartupScript"));
			// Cache member serializers
			populationsSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Population>>.Create(serializerSelector);
			countriesSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Country>>.Create(serializerSelector);
			believesSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Believe>>.Create(serializerSelector);
			statesSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.State>>.Create(serializerSelector);
			provincesSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,Strategy.Province>>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.GameManager obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.StartupScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.GameManager)parentObj;

            populationsSerializer.Serialize(ref obj.populations, mode, stream);
            countriesSerializer.Serialize(ref obj.countries, mode, stream);
            believesSerializer.Serialize(ref obj.believes, mode, stream);
            statesSerializer.Serialize(ref obj.states, mode, stream);
            provincesSerializer.Serialize(ref obj.provinces, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_PopulationSerializer : ClassDataSerializer<Strategy.Population>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.String> nameSerializer;
		private DataSerializer<System.Int32> pop_idSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>> believesSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>> religionsSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
			pop_idSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
			believesSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.Population obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.Population)parentObj;

            nameSerializer.Serialize(ref obj.name, mode, stream);
            pop_idSerializer.Serialize(ref obj.pop_id, mode, stream);
            believesSerializer.Serialize(ref obj.believes, mode, stream);
            believesSerializer.Serialize(ref obj.religions, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_StateSerializer : ClassDataSerializer<Strategy.State>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.Collections.Generic.List<System.Int32>> provincesSerializer;
		private DataSerializer<System.String> state_nameSerializer;
		private DataSerializer<System.Int32> state_idSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>> populationsSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			provincesSerializer = MemberSerializer<System.Collections.Generic.List<System.Int32>>.Create(serializerSelector);
			state_nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
			state_idSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
			populationsSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.State obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.State)parentObj;

            provincesSerializer.Serialize(ref obj.provinces, mode, stream);
            state_nameSerializer.Serialize(ref obj.state_name, mode, stream);
            state_idSerializer.Serialize(ref obj.state_id, mode, stream);
            populationsSerializer.Serialize(ref obj.populations, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_ProvinceSerializer : ClassDataSerializer<Strategy.Province>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.String> nameSerializer;
		private DataSerializer<System.Int32> province_idSerializer;
		private DataSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>> populationsSerializer;
		private DataSerializer<System.Collections.Generic.List<System.Int32>> citiesSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
			province_idSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
			populationsSerializer = MemberSerializer<System.Collections.Generic.Dictionary<System.Int32,System.Int32>>.Create(serializerSelector);
			citiesSerializer = MemberSerializer<System.Collections.Generic.List<System.Int32>>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.Province obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.Province)parentObj;

            nameSerializer.Serialize(ref obj.name, mode, stream);
            province_idSerializer.Serialize(ref obj.province_id, mode, stream);
            populationsSerializer.Serialize(ref obj.populations, mode, stream);
            citiesSerializer.Serialize(ref obj.cities, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}

namespace SiliconStudio.DataSerializers
{
	sealed class Strategy_ReligionSerializer : ClassDataSerializer<Strategy.Religion>
	{
		private DataSerializer<SiliconStudio.Xenko.Engine.AsyncScript> parentSerializer;
		private DataSerializer<System.Int32> religion_idSerializer;
		private DataSerializer<System.String> nameSerializer;

		public override void Initialize(SerializerSelector serializerSelector)
		{
			// Get parent serializer
			parentSerializer = serializerSelector.GetSerializer<SiliconStudio.Xenko.Engine.AsyncScript>();
			if (parentSerializer == null)
				throw new InvalidOperationException(string.Format("Could not find parent serializer for type {0}", @"SiliconStudio.Xenko.Engine.AsyncScript"));
			// Cache member serializers
			religion_idSerializer = MemberSerializer<System.Int32>.Create(serializerSelector);
			nameSerializer = MemberSerializer<System.String>.Create(serializerSelector);
		}

		public override void Serialize(ref Strategy.Religion obj, ArchiveMode mode, SerializationStream stream)
		{
			// Serialize parent (for now we don't copy reference back because it shouldn't change)
			SiliconStudio.Xenko.Engine.AsyncScript parentObj = obj;
			parentSerializer.Serialize(ref parentObj, mode, stream);
			obj = (Strategy.Religion)parentObj;

            religion_idSerializer.Serialize(ref obj.religion_id, mode, stream);
            nameSerializer.Serialize(ref obj.name, mode, stream);
		}

		internal static void ForceGenericInstantiation()
		{
		}
	}
}