using System;

namespace _01_การบ้าน4._2
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Current half DNA sequence :");
            string halfDNASequence = Console.ReadLine().ToUpper();
            char[] nucleotide = halfDNASequence.ToCharArray();
            if (IsValidSequence(halfDNASequence) == false)                      //false
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }
            else                                                                //true
            {
                Console.Write("Do you want to replicate it ? (Y/N) :");
                char YorN1 = char.Parse(Console.ReadLine());
                switch (YorN1)
                {
                    default:
                        do
                        {
                            Console.WriteLine("Please input Y or N :");
                            YorN1 = char.Parse(Console.ReadLine());
                        } while (YorN1 == 'N' && YorN1 == 'n' && YorN1 == 'Y' && YorN1 == 'y');
                        if (YorN1 == 'Y' && YorN1 == 'y')
                        {
                            Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));
                        }
                        break;
                    case 'Y':
                        Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));
                        break;
                    case 'N':
                        break;
                    case 'n':
                        break;
                }
            }
            Console.Write("Do you want to process another sequence ? (Y/N) :");
            char YorN2 = char.Parse(Console.ReadLine());
            switch (YorN2)
            {
                default:
                    do
                    {
                        Console.WriteLine("Please input Y or N :");
                        YorN2 = char.Parse(Console.ReadLine());
                    } while (YorN2 == 'N' && YorN2 == 'n' && YorN2 == 'Y' && YorN2 == 'y');
                    if (YorN2 == 'Y' && YorN2 == 'y')
                    {
                        Main();
                    }
                    break;
                case 'Y':
                    Main();
                    break;
                case 'N':
                    break;
                case 'n':
                    break;
            }
        }
        static string ReplicateSeqeunce(string halfDNASequence)                  //true
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }
        static bool IsValidSequence(string halfDNASequence)                      //false
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
    }
}
