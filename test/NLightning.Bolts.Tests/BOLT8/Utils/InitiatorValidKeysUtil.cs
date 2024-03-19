namespace NLightning.Bolts.Tests.BOLT8.Utils;

using static TestUtils;

internal static class InitiatorValidKeysUtil
{
    public static byte[] RemoteStaticPublicKey { get; }
    public static byte[] LocalStaticPrivateKey { get; }
    public static byte[] EphemeralPrivateKey { get; }
    public static byte[] ActOneOutput { get; }
    public static byte[] ActTwoInput { get; }
    public static byte[] ActThreeOutput { get; }
    public static byte[] OutputSk { get; }
    public static byte[] OutputRk { get; }

    static InitiatorValidKeysUtil()
    {
        RemoteStaticPublicKey = GetBytes("0x028d7500dd4c12685d1f568b4c2b5048e8534b873319f3a8daa612b469132ec7f7");
        LocalStaticPrivateKey = GetBytes("0x1111111111111111111111111111111111111111111111111111111111111111");
        EphemeralPrivateKey = GetBytes("0x1212121212121212121212121212121212121212121212121212121212121212");
        ActOneOutput = GetBytes("0x00036360e856310ce5d294e8be33fc807077dc56ac80d95d9cd4ddbd21325eff73f70df6086551151f58b8afe6c195782c6a");
        ActTwoInput = GetBytes("0x0002466d7fcae563e5cb09a0d1870bb580344804617879a14949cf22285f1bae3f276e2470b93aac583c9ef6eafca3f730ae");
        ActThreeOutput = GetBytes("0x00b9e3a702e93e3a9948c2ed6e5fd7590a6e1c3a0344cfc9d5b57357049aa22355361aa02e55a8fc28fef5bd6d71ad0c38228dc68b1c466263b47fdf31e560e139ba");
        OutputSk = GetBytes("0x969ab31b4d288cedf6218839b27a3e2140827047f2c0f01bf5c04435d43511a9");
        OutputRk = GetBytes("0xbb9020b8965f4df047e07f955f3c4b88418984aadc5cdb35096b9ea8fa5c3442");
    }
}