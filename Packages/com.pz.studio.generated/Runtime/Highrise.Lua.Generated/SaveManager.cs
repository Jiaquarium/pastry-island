/*

    Copyright (c) 2025 Pocketz World. All rights reserved.

    This is a generated file, do not edit!

    Generated by com.pz.studio
*/

#if UNITY_EDITOR

using System;
using System.Linq;
using UnityEngine;
using Highrise.Client;
using Highrise.Studio;
using Highrise.Lua;

namespace Highrise.Lua.Generated
{
    [AddComponentMenu("Lua/SaveManager")]
    [LuaRegisterType(0x20b003380bb3b8d7, typeof(LuaBehaviour))]
    public class SaveManager : LuaBehaviourThunk
    {
        private const string s_scriptGUID = "8ba6081e447c94a75aa3949adc710465";
        public override string ScriptGUID => s_scriptGUID;


        protected override SerializedPropertyValue[] SerializeProperties()
        {
            if (_script == null)
                return Array.Empty<SerializedPropertyValue>();

            return new SerializedPropertyValue[]
            {
            };
        }
    }
}

#endif
