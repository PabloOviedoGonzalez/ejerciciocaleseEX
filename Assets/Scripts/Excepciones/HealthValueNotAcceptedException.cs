using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization;



[Serializable]
public class HealthValueNotAcceptedException : Exception
{
    // Start is called before the first frame update
    public HealthValueNotAcceptedException() : base("Health value not accepted")
    {

    }

    // Update is called once per frame
    protected HealthValueNotAcceptedException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}
