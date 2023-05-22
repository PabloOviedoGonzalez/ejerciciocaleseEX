using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization;

public class StaminaValueNotAcceptedException : Exception
{
    // Start is called before the first frame update
    public StaminaValueNotAcceptedException() : base("Stamina value not accepted")
    {

    }

    // Update is called once per frame
    protected StaminaValueNotAcceptedException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}