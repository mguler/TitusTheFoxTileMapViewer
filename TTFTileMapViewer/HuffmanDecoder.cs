using System;
using System.Collections.Generic;

namespace TTFTileMapViewer
{

    public static class HuffmanDecompression
    {
        // Node for the Huffman Tree
        class Node
        {
            public int Frequency { get; set; }
            public char? Symbol { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        // Function to decompress the input string
        static string Decompress(string input, Dictionary<string, char> codes)
        {
            Node root = BuildHuffmanTree(codes);
            Node current = root;
            string result = "";

            foreach (char bit in input)
            {
                if (bit == '0')
                    current = current.Left;
                else
                    current = current.Right;

                if (current.Symbol != null)
                {
                    result += current.Symbol;
                    current = root;
                }
            }

            return result;
        }

        // Function to build the Huffman Tree from given codes
        static Node BuildHuffmanTree(Dictionary<string, char> codes)
        {
            // Create a priority queue for the nodes
            SortedDictionary<int, Node> queue = new SortedDictionary<int, Node>();

            // Create a node for each symbol with its frequency
            foreach (var code in codes)
            {
                queue.Add(code.Key.Length, new Node { Frequency = 1, Symbol = code.Value });
            }

            // Build the Huffman Tree
            while (queue.Count > 1)
            {
                // Extract the two nodes with lowest frequency
                var left = queue.First();
                queue.Remove(left.Key);
                var right = queue.First();
                queue.Remove(right.Key);

                // Create a new node with combined frequency
                var newNode = new Node
                {
                    Frequency = left.Key + right.Key,
                    Left = left.Value,
                    Right = right.Value
                };

                // Add the new node back to the queue
                queue.Add(left.Key + right.Key, newNode);
            }

            // Return the root of the Huffman Tree
            return queue.First().Value;
        }

        //// Main method for testing
        //static void Main(string[] args)
        //{
        //    // Example input string and codes (replace with actual compressed data and codes)
        //    string compressedData = "101110010110101010111011011110101101";
        //    Dictionary<string, char> codes = new Dictionary<string, char>()
        //{
        //    { "0", 'a' },
        //    { "10", 'b' },
        //    { "110", 'c' },
        //    { "111", 'd' }
        //};

        //    // Decompress the data
        //    string decompressedData = Decompress(compressedData, codes);

        //    Console.WriteLine("Decompressed Data: " + decompressedData);
        //}
    }

}
