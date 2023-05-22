using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization;



[Serializable]
public class StructureLlenaEmptyException : Exception
{
    // Start is called before the first frame update
    public StructureLlenaEmptyException() : base("Estructura llena")
    {

    }

    // Update is called once per frame
    protected StructureLlenaEmptyException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}