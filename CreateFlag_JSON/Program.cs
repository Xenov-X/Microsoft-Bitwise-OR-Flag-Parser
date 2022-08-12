using System.Text.Json;
using System.IO;
string FlagName = "flag_name";
string Store = "flag_maps";

Dictionary<string, int> Flags =
    new Dictionary<string, int>();

// Add some elements to the dictionary. There are no
// duplicate keys, but some of the values are duplicates.
Flags.Add("CT_FLAG_REQUIRE_PRIVATE_KEY_ARCHIVAL", unchecked((int)0x00000001));
Flags.Add("CT_FLAG_EXPORTABLE_KEY", unchecked((int)0x00000010));
Flags.Add("CT_FLAG_STRONG_KEY_PROTECTION_REQUIRED", unchecked((int)0x00000020));
Flags.Add("CT_FLAG_REQUIRE_ALTERNATE_SIGNATURE_ALGORITHM", unchecked((int)0x00000040));
Flags.Add("CT_FLAG_REQUIRE_SAME_KEY_RENEWAL", unchecked((int)0x00000080));
Flags.Add("CT_FLAG_USE_LEGACY_PROVIDER", unchecked((int)0x00000100));
Flags.Add("CT_FLAG_ATTEST_NONE", unchecked((int)0x00000000));
Flags.Add("CT_FLAG_ATTEST_REQUIRED", unchecked((int)0x00002000));
Flags.Add("CT_FLAG_ATTEST_PREFERRED", unchecked((int)0x00001000));
Flags.Add("CT_FLAG_ATTESTATION_WITHOUT_POLICY", unchecked((int)0x00004000));
Flags.Add("CT_FLAG_EK_TRUST_ON_USE", unchecked((int)0x00000200));
Flags.Add("CT_FLAG_EK_VALIDATE_CERT", unchecked((int)0x00000400));
Flags.Add("CT_FLAG_EK_VALIDATE_KEY", unchecked((int)0x00000800));
Flags.Add("CT_FLAG_HELLO_KSP_KEY", unchecked((int)0x00100000));
Flags.Add("CT_FLAG_HELLO_LOGON_KEY", unchecked((int)0x80000000));

//Flags.ToList().ForEach(x => Console.WriteLine(x.Value + "," + x.Key));


System.IO.Directory.CreateDirectory(Store);

JsonSerializerOptions options = new() { WriteIndented = true };

File.WriteAllText(Store + "\\" + FlagName + ".json", JsonSerializer.Serialize(Flags, options));


