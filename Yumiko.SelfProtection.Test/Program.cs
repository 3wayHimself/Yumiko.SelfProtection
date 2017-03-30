﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Collections;
using Yumiko.SelfProtection.WMI;
using System.Security.Cryptography;
using Yumiko.SelfProtection.Core;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder;

namespace Yumiko.SelfProtection.Test
{

    class Program 
    {

        static void Main(string[] args)
        {

            var s = new Strobarried(new WMIProvider(WMISubject.Win32_BootConfiguration));

            var result = Strobarried.Validate(s, @"E:\Git\Yumiko.SelfProtection\Yumiko.SelfProtection.Test\bin\Debug\Bind.dll");
            Console.WriteLine(result);

            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
        
    } 
    
    
}
