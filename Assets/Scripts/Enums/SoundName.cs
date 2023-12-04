using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESoundName
{
    // SFX sounds
    public static string SampleTest {  get { return "sample_test"; } }

    // Piano Tone
    public static string[] Piano { get { return new string[] { Do, Re, Mi, Fa, Sol, La, Si }; } }

    private static string Do { get { return "do"; } }
    private static string Re { get { return "re"; } }
    private static string Mi { get { return "mi"; } }
    private static string Fa { get { return "fa"; } }
    private static string Sol { get { return "sol"; } }
    private static string La { get { return "la"; } }
    private static string Si { get { return "si"; } }
}