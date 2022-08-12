using System.Text.Json;

void Show_usage()
{
    Console.WriteLine("this.exe <flagname> <flaginteger>");
}

if ( Environment.GetCommandLineArgs().Length < 3)
{
    Show_usage();
    Environment.Exit(1);
} 

Console.WriteLine("Decoding flag: "  + Environment.GetCommandLineArgs()[1]);
Console.WriteLine("Flag value: " + Environment.GetCommandLineArgs()[2]);

Dictionary<string, int> Flags =
    new Dictionary<string, int>();

string json;
string path = "flag_maps\\" + Environment.GetCommandLineArgs()[1] + ".json";

if (!File.Exists(path))
{
    Console.WriteLine("File dosen't exist!! - " + path);
    return;
} else {
    json = File.ReadAllText(path);
}

    
    Flags = JsonSerializer.Deserialize<Dictionary<string, int>>(json);
Console.WriteLine("Imported Flags\n----------------------------------------");    
    Flags.ToList().ForEach(x => Console.WriteLine(x.Value + "," + x.Key));
Console.WriteLine("\n----------------------------------------\nResult\n----------------------------------------");


int z = Convert.ToInt32(Environment.GetCommandLineArgs()[2]);


    if (Flags.Count >= 1)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            /*ComputedFlags.Add(
                entry0.Key, 
                entry0.Value);*/
            if (0 == (z & ~entry0.Value))
            {
                Console.WriteLine(entry0.Key); return;
            }
        }
    }

    if (Flags.Count >= 2)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {

                /*ComputedFlags.Add(entry0.Key + "|" + entry1.Key,
                    entry0.Value | entry1.Value
                    );*/
                if (0 == (z & ~entry0.Value & ~entry1.Value))
                {
                    Console.WriteLine(entry0.Key + " | " + entry1.Key); return;
                }
            }
        }
    }

    if (Flags.Count >= 3)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    /*ComputedFlags.Add(
                        entry0.Key + "|" + entry1.Key + "|" + entry2.Key, 
                        entry0.Value | entry1.Value | entry2.Value
                        );*/
                    if (0 == (z & ~entry0.Value & ~entry1.Value & ~entry2.Value))
                    {
                        Console.WriteLine(entry0.Key + " | " + entry1.Key + " | " + entry2.Key); return;
                    }
                }

            }
        }
    }

    if (Flags.Count >= 4)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    foreach (KeyValuePair<string, int> entry3 in Flags)
                    {
                        if (0 == (z & ~entry0.Value & ~entry1.Value & ~entry2.Value & ~entry3.Value))
                        {
                            Console.WriteLine(entry0.Key + " | " + entry1.Key + " | " + entry2.Key + " | " + entry3.Key); return;
                        }
                    }
                }

            }
        }
    }


    if (Flags.Count >= 5)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    foreach (KeyValuePair<string, int> entry3 in Flags)
                    {
                        foreach (KeyValuePair<string, int> entry4 in Flags)
                        {
                            if (0 == (z & ~entry0.Value & ~entry1.Value & ~entry2.Value & ~entry3.Value & ~entry4.Value))
                            {
                                Console.WriteLine(entry0.Key + " | " + entry1.Key + " | " + entry2.Key + " | " + entry3.Key + " | " + entry4.Key); return;
                            }

                        }

                    }

                }

            }
        }
    }


    if (Flags.Count >= 6)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    foreach (KeyValuePair<string, int> entry3 in Flags)
                    {
                        foreach (KeyValuePair<string, int> entry4 in Flags)
                        {
                            foreach (KeyValuePair<string, int> entry5 in Flags)
                            {
                                if (0 == (z & ~entry0.Value & ~entry1.Value & ~entry2.Value & ~entry3.Value & ~entry4.Value & ~entry5.Value))
                                {
                                    Console.WriteLine(entry0.Key + " | " + entry1.Key + " | " + entry2.Key + " | " + entry3.Key + " | " + entry4.Key + " | " + entry5.Key); return;
                                }

                            }

                        }

                    }

                }

            }
        }
    }

    if (Flags.Count >= 7)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    foreach (KeyValuePair<string, int> entry3 in Flags)
                    {
                        foreach (KeyValuePair<string, int> entry4 in Flags)
                        {
                            foreach (KeyValuePair<string, int> entry5 in Flags)
                            {

                                foreach (KeyValuePair<string, int> entry6 in Flags)
                                {
                                    if (0 == (z & ~entry0.Value & ~entry1.Value & ~entry2.Value & ~entry3.Value & ~entry4.Value & ~entry5.Value & ~entry6.Value))
                                    {
                                        Console.WriteLine(entry0.Key + " | " + entry1.Key + " | " + entry2.Key + " | " + entry3.Key + " | " + entry4.Key + " | " + entry5.Key + " | " + entry6.Key); return;
                                    }

                                }
                            }

                        }

                    }

                }

            }
        }
    }
    /*
    if (Flags.Count >= 8)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    foreach (KeyValuePair<string, int> entry3 in Flags)
                    {
                        foreach (KeyValuePair<string, int> entry4 in Flags)
                        {
                            foreach (KeyValuePair<string, int> entry5 in Flags)
                            {

                                foreach (KeyValuePair<string, int> entry6 in Flags)
                                {
                                    foreach (KeyValuePair<string, int> entry7 in Flags)
                                    {
                                        ComputedFlags.Add(
                                        entry0.Key + "|" + entry1.Key + "|" + entry2.Key + "|" + entry3.Key + "|" + entry4.Key + "|" + entry5.Key + "|" + entry6.Key + "|" + entry7.Key,
                                        entry0.Value | entry1.Value | entry2.Value | entry3.Value | entry4.Value | entry5.Value | entry6.Value | entry7.Value
                                        );

                                    }

                                }
                            }

                        }

                    }

                }

            }
        }
    }
    Console.WriteLine("8 - done");

    if (Flags.Count >= 9)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    foreach (KeyValuePair<string, int> entry3 in Flags)
                    {
                        foreach (KeyValuePair<string, int> entry4 in Flags)
                        {
                            foreach (KeyValuePair<string, int> entry5 in Flags)
                            {

                                foreach (KeyValuePair<string, int> entry6 in Flags)
                                {
                                    foreach (KeyValuePair<string, int> entry7 in Flags)
                                    {

                                        foreach (KeyValuePair<string, int> entry8 in Flags)
                                        {
                                            ComputedFlags.Add(
                                            entry0.Key + "|" + entry1.Key + "|" + entry2.Key + "|" + entry3.Key + "|" + entry4.Key + "|" + entry5.Key + "|" + entry6.Key + "|" + entry7.Key + "|" + entry8.Key,
                                            entry0.Value | entry1.Value | entry2.Value | entry3.Value | entry4.Value | entry5.Value | entry6.Value | entry7.Value | entry8.Value
                                            );

                                        }
                                    }

                                }
                            }

                        }

                    }

                }

            }
        }
    }
    Console.WriteLine("9 - done");
    if (Flags.Count >= 10)
    {
        foreach (KeyValuePair<string, int> entry0 in Flags)
        {
            foreach (KeyValuePair<string, int> entry1 in Flags)
            {
                foreach (KeyValuePair<string, int> entry2 in Flags)
                {
                    foreach (KeyValuePair<string, int> entry3 in Flags)
                    {
                        foreach (KeyValuePair<string, int> entry4 in Flags)
                        {

                            foreach (KeyValuePair<string, int> entry5 in Flags)
                            {

                                foreach (KeyValuePair<string, int> entry6 in Flags)
                                {
                                    foreach (KeyValuePair<string, int> entry7 in Flags)
                                    {

                                        foreach (KeyValuePair<string, int> entry8 in Flags)
                                        {
                                            foreach (KeyValuePair<string, int> entry9 in Flags)
                                            {
                                                ComputedFlags.Add(
                                                entry0.Key + "|" + entry1.Key + "|" + entry2.Key + "|" + entry3.Key + "|" + entry4.Key + "|" + entry5.Key + "|" + entry6.Key + "|" + entry7.Key + "|" + entry8.Key + "|" + entry9.Key,
                                                entry0.Value | entry1.Value | entry2.Value | entry3.Value | entry4.Value | entry5.Value | entry6.Value | entry7.Value | entry8.Value | entry9.Value
                                                );

                                            }

                                        }
                                    }

                                }
                            }

                        }

                    }

                }

            }
        }
    }/*/
    Console.WriteLine("Reached end of attempts to decode");



//int c = CT_FLAG_INCLUDE_SYMMETRIC_ALGORITHMS | CT_FLAG_PEND_ALL_REQUESTS | CT_FLAG_PUBLISH_TO_KRA_CONTAINER | CT_FLAG_PUBLISH_TO_DS | CT_FLAG_AUTO_ENROLLMENT_CHECK_USER_DS_CERTIFICATE | CT_FLAG_AUTO_ENROLLMENT | CT_FLAG_PREVIOUS_APPROVAL_VALIDATE_REENROLLMENT | CT_FLAG_USER_INTERACTION_REQUIRED | CT_FLAG_REMOVE_INVALID_CERTIFICATE_FROM_PERSONAL_STORE | CT_FLAG_ALLOW_ENROLL_ON_BEHALF_OF | CT_FLAG_ADD_OCSP_NOCHECK | CT_FLAG_ENABLE_KEY_REUSE_ON_NT_TOKEN_KEYSET_STORAGE_FULL | CT_FLAG_NOREVOCATIONINFOINISSUEDCERTS | CT_FLAG_INCLUDE_BASIC_CONSTRAINTS_FOR_EE_CERTS | CT_FLAG_ALLOW_PREVIOUS_APPROVAL_KEYBASEDRENEWAL_VALIDATE_REENROLLMENT | CT_FLAG_ISSUANCE_POLICIES_FROM_REQUEST | CT_FLAG_SKIP_AUTO_RENEWAL;
//Console.WriteLine(c);
//Console.WriteLine(Convert.ToString(c, toBase: 2));

