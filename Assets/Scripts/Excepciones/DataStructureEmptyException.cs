using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization;



[Serializable]
public class DataStructureEmptyException : Exception
{
    // Start is called before the first frame update
    public DataStructureEmptyException() : base("Estructura vacía")
    {

    }

    // Update is called once per frame
    protected DataStructureEmptyException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}
