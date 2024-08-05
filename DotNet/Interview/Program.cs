﻿using System;
using Interview.AdvancedOOPS;
using Interview.InterviewQuestionsAsked;

namespace Interview
{
    /*
        History of C#
        The C# programming language was born in 1999 at Microsoft. The original name was COOL for C-like Object Oriented Language but it was later changed to C#.
        
        It was created by Anders Hejlsberg to help address the shortcomings of other programming languages in use at the time. The language is strongly-typed,
        object-oriented and component oriented and utilizes a unified type system. Unlike C or C++, C# handles memory and resource management for developer, lending
        to the concept of managed code. C# uses a garbage collection mechanism to release memory and resources that are no longer referenced in the application code,
        helping to prevent memory leak issues.
        
        1. Strongly-typed - the languages enforces type checking on objects in the code meaning it is type-safe.
        2. Object-oriented - C# offers the developer all the tenets of OOP such as encapsulation, inheritance and polymorphism.
        3. Component-oriented - C# permits the creation of software components for self-contained, self-describing packages of functionality.
        4. Unified type system - all C# types from primitive to reference types, inherit from a single root known as Object.
    */

    class Program
    {
        static void Main(string[] args)
        {
            StringExtend stringExtend = new StringExtend();
            stringExtend.Extend();

            //NewProgram program = new NewProgram();
            //program.Method();

            AnotherThrowExceptionVsThrowClause throwExceptionVsThrowClause = new AnotherThrowExceptionVsThrowClause();
            throwExceptionVsThrowClause.MainMethod();
        }
    }
}
