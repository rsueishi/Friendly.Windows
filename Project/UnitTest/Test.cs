﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Check()
        {
            using (var app = new WindowsAppFriend(Process.GetProcessesByName("Hoge.R01.Start")[0]))
            {
            }
        }
    }
}