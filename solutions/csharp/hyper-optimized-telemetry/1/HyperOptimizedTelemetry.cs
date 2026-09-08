public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        byte[] payload;
        bool signed;

        if (reading >= ushort.MinValue && reading <= ushort.MaxValue)
        {
            payload = BitConverter.GetBytes((ushort)reading);
            signed = false;
        }
        else if (reading >= short.MinValue && reading <= short.MaxValue)
        {
            payload = BitConverter.GetBytes((short)reading);
            signed = true;
        }
        else if (reading >= int.MinValue && reading <= int.MaxValue)
        {
            payload = BitConverter.GetBytes((int)reading);
            signed = true;
        }
        else if (reading >= uint.MinValue && reading <= uint.MaxValue)
        {
            payload = BitConverter.GetBytes((uint)reading);
            signed = false;
        }
        else
        {
            payload = BitConverter.GetBytes(reading);
            signed = true;
        }

        buffer[0] = signed ? (byte)(256 - payload.Length) : (byte)payload.Length;
        Array.Copy(payload, 0, buffer, 1, payload.Length);

        return buffer;
    }

   public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];

        int unsignedLength = prefix;
        int signedLength = 256 - prefix;

        bool validUnsigned = unsignedLength == 2 || unsignedLength == 4 || unsignedLength == 8;
        bool validSigned = signedLength == 2 || signedLength == 4 || signedLength == 8;

        if (!validUnsigned && !validSigned)
        {
            return 0;
        }

        bool signed = !validUnsigned;
        int length = signed ? signedLength : unsignedLength;

        byte[] payload = new byte[length];
        Array.Copy(buffer, 1, payload, 0, length);

        return length switch
        {
            2 => signed ? BitConverter.ToInt16(payload, 0) : BitConverter.ToUInt16(payload, 0),
            4 => signed ? BitConverter.ToInt32(payload, 0) : BitConverter.ToUInt32(payload, 0),
            8 => BitConverter.ToInt64(payload, 0),
            _ => 0
        };
    }
}
