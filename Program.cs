using System;

namespace DNA_Replication
{
    class Program
    {
        static void Main(string[] args)
        {
            Newprogram();
        }
        static void Newprogram()
        {
            string halfDNASequence,x,result;
            bool a;
            halfDNASequence = Console.ReadLine();
            a = IsValidSequence(halfDNASequence);
            if (a == true)
            {
                Console.WriteLine("Current half DNA sequence : {0}",halfDNASequence);
                Console.Write("Do you want to replicate it ? (Y/N) :");
                x = YorN();
                if (x == "Y")
                {
                    result = ReplicateSeqeunce(halfDNASequence);
                    Console.WriteLine("Replicated half DNA sequence : {0}", result);
                    Another();
                }
                else { Another(); }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                Another(); 
            }
        }
        static void Another()
        {
            string x;
            Console.Write("Do you want to process another sequence ? (Y / N) : ");
            x = YorN();
            if (x == "Y") { Newprogram(); }
        }
        static string YorN()
        {
            string x;
            do
            {
                x = Console.ReadLine();
                if (x != "Y" && x != "N")
                { Console.WriteLine("Please input Y or N"); }
            } while (x != "Y" && x != "N");
            return x;
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
    }
}
