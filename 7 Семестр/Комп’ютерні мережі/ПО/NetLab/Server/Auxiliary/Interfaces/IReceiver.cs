namespace Server.Auxiliary
{
    public interface IReceiver
    {
        byte[] ProcessData(byte[] data);
    }
}
