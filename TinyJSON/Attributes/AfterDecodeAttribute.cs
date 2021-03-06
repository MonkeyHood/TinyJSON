﻿using System;

namespace TinyJSON
{
    [Obsolete("Load has been renamed to AfterDecode please use attribute instead.", error:true)]
    public sealed class Load : AfterDecodeAttribute
    {

    }


    /// <summary>
    /// Mark methods to be called after an object is decoded. This function can take no arguments or
    /// take a object that is assignable from <see cref="Variant"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class AfterDecodeAttribute : Attribute
    {
    }
}
