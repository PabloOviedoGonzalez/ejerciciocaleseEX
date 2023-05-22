using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
public class ForgotToAddComponentException : Exception
{
    public ForgotToAddComponentException() : base("Hey! You forgot to add a component to this GameObject")
    {
        
    }

    // SerializableConstructor
    protected ForgotToAddComponentException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}
