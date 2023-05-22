using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization;

public class DataStructureEmptyException : Exception
{
    // Start is called before the first frame update
    public DataStructureEmptyException() : base("Health value not accepted")
    {

    }

    // Update is called once per frame
    protected DataStructureEmptyException(SerializationInfo info, StreamingContext ctxt) : base(info, ctxt)
    {

    }
}
