﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SideScrollerCharacter2DTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void SideScrollerCharacter2DTestSimplePasses()
        {
            // Use the Assert class to test conditions
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SideScrollerCharacter2DTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
