namespace TTFTileMapViewer
{
    public class LZWDecoder
    {
        const int CLEAR_CODE = 0x100;
        const int END_CODE = 0x101;
        const int MAX_TABLE = 0x1000;

        List<byte[]> dictionary;
        int nbit;

        public LZWDecoder()
        {
            InitializeDictionary();
        }

        private void InitializeDictionary()
        {
            dictionary = new List<byte[]>();
            for (int i = 0; i < 256; i++)
            {
                dictionary.Add([(byte)i]);
            }

            dictionary.Add([0]);
            dictionary.Add([0]);
            nbit = 9;
        }

        public Stream Decode(byte[] compressedData)
        {
            var memoryStream = new MemoryStream();
            var bitReader = new BitReader(compressedData);
            bitReader.ReadBits(32);

            var previous = CLEAR_CODE;

            while (previous != END_CODE)
            {
                if (previous == CLEAR_CODE)
                {
                    InitializeDictionary();
                }

                var current = bitReader.ReadBits(nbit);

                if (current != CLEAR_CODE && current != END_CODE)
                {
                    byte newByte = 0;
                    if (current < dictionary.Count)
                    {
                        newByte = dictionary[current][0];
                    }
                    else
                    {
                        newByte = dictionary[previous][0];
                    }

                    if (previous != CLEAR_CODE && dictionary.Count < MAX_TABLE)
                    {
                        var newEntry = new byte[dictionary[previous].Length + 1];
                        Array.Copy(dictionary[previous], newEntry, dictionary[previous].Length);
                        newEntry[newEntry.Length - 1] = newByte;

                        dictionary.Add(newEntry);

                        if (dictionary.Count == (1 << nbit) && nbit < 12)
                        {
                            nbit++;
                        }
                    }
                    memoryStream.Write(dictionary[current], 0, dictionary[current].Length);
                }
                previous = current;
            }
            memoryStream.Position = 0;
            return memoryStream;
        }
    }


    class BitReader
    {
        private readonly byte[] data;
        private int bitIndex;
        private int byteIndex;

        public BitReader(byte[] data)
        {
            this.data = data;
            bitIndex = 7;
            byteIndex = 0;
        }
        public int ReadBits(int count)
        {
            var result = 0;
            for (var index = 0; index < count; index++)
            {
                int bitValue = (data[byteIndex] >> bitIndex) & 1;
                result <<= 1;
                result |= bitValue;

                bitIndex--;

                if (bitIndex == -1)
                {
                    bitIndex = 7;
                    byteIndex++;
                }
            }
            return result;
        }
    }
}
