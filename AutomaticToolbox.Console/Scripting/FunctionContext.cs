﻿namespace AutomaticToolbox.Console.Scripting;

public class FunctionContext
{
    public object Source { get; private set; }

    public void SetSource(object source) => 
        Source = source;
}