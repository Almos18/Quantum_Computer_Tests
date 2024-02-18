using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum_Factorization
{
    class Shor_Algorithm
    {
        private static long Calculate_GCD(long a, long N){
            long rem = 0;
            while(a!=0){
                rem = N%a;
                N = a;
                a = rem;
            }
            return N;
        }

        private static long Calculate_Pow(long a, long r, long N){
            long res = 1;
            while (r>0){
                if(r%2==1){
                    res = (res*a)%N;
                }
                a = (a*a)%N;
                r/=2;
            }
            return res%N;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("This programs takes a composite number as an input and outputs its 2 non-trivial factors");
            Console.WriteLine("Enter a number (value of N):");
            int N = Convert.ToInt32(Console.ReadLine());
            if(N%2==0){
                Console.WriteLine("Since entered number is even, it has a trivial factor 2");
                long temp = N/2;
                Console.WriteLine("The other factor is "+temp);
                return;
            }
            //Choosing a random number. Since the probability of choosing a suitable random number is >1/2. Running for N/2 trials.
            long iterations = (int)Math.Ceiling((N/2.0));
            long period;
            for (long iter =0;iter<iterations;iter++){
                try{
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("Iteration #"+(iter+1)+":");
                    Random rand_gen = new Random();
                    int a = (int)rand_gen.Next(2,N);
                    int[] previous_guesses = new int[250];
                    for(int j=0;j<previous_guesses.Length;j++){
                        if(a==previous_guesses[j])
                        {
                        a = (int)rand_gen.Next(2,N);
                        j=0;
                        }
                    }
                    previous_guesses[iter] = a;
                    Console.WriteLine("Random number generated is "+a);
                    long gcd = Calculate_GCD(a,N);
                    Console.WriteLine("Calculated GCD is "+gcd);
                    if(gcd>1){
                        Console.WriteLine("The randomly chosen number " + a + " is not co-prime to "+N);
                        Console.WriteLine("This is a trivial case, hence quantum operations are not required");
                        Console.WriteLine("Hence the factors of " + N + " are: " + gcd + " " +  (N/gcd));
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        continue;
                        // return;
                    }
                    else if((a*a)%N==1){
                        Console.WriteLine("Since a^2%n==1. Cannot continue with this random number " + a);
                        Console.WriteLine("This iteration of Shor's algorithm failed. Trying again...");
                        Console.WriteLine("---------------------------------------------------------");
                        continue;
                    }
                    else if(a%N==1 || a%N==-1){
                        Console.WriteLine("Since a%n==(+-)1. Cannot continue with this random number" + a);
                        Console.WriteLine("This iteration of Shor's algorithm failed. Trying again...");
                        Console.WriteLine("---------------------------------------------------------");
                        continue;
                    }
                    using (var qsim = new QuantumSimulator())
                    {
                        period = find_Period.Run(qsim,a,N).Result;
                        Console.WriteLine("The period for " + a + " is " + period);
                    }
                    if(period%2!=0){
                        Console.WriteLine("This iteration of Shor's algorithm failed. Trying again...");
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine();
                        continue;
                    }
                    long a_exp_r_half = Calculate_Pow(a,period/2,N);
                    if(a_exp_r_half != N-1){
                        long factor_candidate1 = Calculate_GCD(a_exp_r_half-1,N);
                        long factor_candidate2 = Calculate_GCD(a_exp_r_half+1,N);
                        long factor1 = (factor_candidate1>=factor_candidate2)? factor_candidate1 : factor_candidate2;
                        long factor2 = N/factor1;
                        Console.WriteLine("The factors of " + N + " are: " + factor1 + " " +  factor2);
                        Console.WriteLine("---------------------------------------------------------");
                        return;
                    }
                    else{
                        Console.WriteLine("This iteration of Shor's algorithm failed since a^r = -1 % N. Trying again...");
                        Console.WriteLine("---------------------------------------------------------");
                    }
                }
                catch (AggregateException ex){
                    Console.WriteLine("Shor's algorithm failed for this trial");
                    foreach(Exception ex_inner in ex.InnerExceptions){
                        if (ex_inner is ExecutionFailException failException){
                            Console.WriteLine($" {failException.Message}");
                        }
                    }
                }
                
            }
            
        }
    }
}