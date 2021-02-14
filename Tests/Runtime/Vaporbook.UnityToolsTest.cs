
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vaporbook.UnityToolsTest {

    public static class Tests {

        public static void RunTests()
        {
            // TESTDEF Vaporbook.UnityTools.Transforms.CenterInWorld
            GameObject gob = CreateInstance<GameObject>();
            Vaporbook.UnityTools.Transforms.CenterInWorld(gob);
        }
    }
}