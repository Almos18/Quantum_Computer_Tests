#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"order_Finding\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generator\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"modulo\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"order_Finding\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":10,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"order_Finding\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":13,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"order_Finding\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":14,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"order_Finding\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"find_Period\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"generator\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"modulo\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"find_Period\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
#line hidden
namespace Quantum_Factorization
{
    public class order_Finding : Unitary<(Int64,Int64,Int64,QArray<Qubit>)>, ICallable
    {
        public order_Finding(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item4)?.Qubits;
        }

        String ICallable.Name => "order_Finding";
        String ICallable.FullName => "Quantum_Factorization.order_Finding";
        protected ICallable<(Int64,Int64,Int64), Int64> MicrosoftQuantumCanonExpMod
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonModularMultiplyByConstantLE
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (generator,modulo,power,target) = __in__;
#line 12 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Apply((MicrosoftQuantumCanonExpMod.Apply((generator, power, modulo)), modulo, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,Int64,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (generator,modulo,power,target) = __in__;
#line hidden
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Adjoint.Apply((MicrosoftQuantumCanonExpMod.Apply((generator, power, modulo)), modulo, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,Int64,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(generator,modulo,power,target)) = __in__;
#line hidden
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumCanonExpMod.Apply((generator, power, modulo)), modulo, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Int64,Int64,Int64,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(generator,modulo,power,target)) = __in__;
#line hidden
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumCanonExpMod.Apply((generator, power, modulo)), modulo, new Microsoft.Quantum.Canon.LittleEndian(target?.Copy()))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.MicrosoftQuantumCanonModularMultiplyByConstantLE = this.Factory.Get<IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularMultiplyByConstantLE));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 generator, Int64 modulo, Int64 power, QArray<Qubit> target)
        {
            return __m__.Run<order_Finding, (Int64,Int64,Int64,QArray<Qubit>), QVoid>((generator, modulo, power, target));
        }
    }

    public class find_Period : Operation<(Int64,Int64), Int64>, ICallable
    {
        public find_Period(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "find_Period";
        String ICallable.FullName => "Quantum_Factorization.find_Period";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Canon.Fraction,Int64), Microsoft.Quantum.Canon.Fraction> MicrosoftQuantumCanonContinuedFractionConvergent
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> MicrosoftQuantumCanonExpMod
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumCanonGCD
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonInPlaceXorLE
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Canon.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected IUnitary<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonQuantumPhaseEstimation
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumExtensionsMathAbsI
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Int64,QArray<Qubit>)> order_Finding
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), Int64> Body => (__in__) =>
        {
            var (generator,modulo) = __in__;
#line 21 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            Message.Apply("Performing Quantum Operations!");
#line 22 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            var result = 1L;
#line 23 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            var qreg_size1 = MicrosoftQuantumCanonBitSize.Apply(modulo);
#line 24 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            var bit_precision = ((2L * qreg_size1) + 1L);
#line 25 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            while (true)
            {
#line 26 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                var approx_sr = 0L;
#line hidden
                {
#line 27 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                    var eigenstate_register = Allocate.Apply(qreg_size1);
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 28 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                        var eigenstate_regLE = new Microsoft.Quantum.Canon.LittleEndian(eigenstate_register?.Copy());
#line 29 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                        MicrosoftQuantumCanonInPlaceXorLE.Apply((1L, eigenstate_regLE));
#line 30 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                        var period_oracle = new Microsoft.Quantum.Canon.DiscreteOracle(order_Finding.Partial(new Func<(Int64,QArray<Qubit>), (Int64,Int64,Int64,QArray<Qubit>)>((__arg3__) => (generator, modulo, __arg3__.Item1, __arg3__.Item2))));
#line hidden
                        {
#line 31 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                            var fraction_qarr = Allocate.Apply(bit_precision);
#line hidden
                            Exception __arg4__ = null;
                            try
                            {
#line 32 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                                var fraction_qarr_BE = new Microsoft.Quantum.Canon.BigEndian(fraction_qarr?.Copy());
#line 33 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                                MicrosoftQuantumCanonQuantumPhaseEstimation.Apply((period_oracle, eigenstate_regLE.Data, fraction_qarr_BE));
#line 34 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                                approx_sr = MicrosoftQuantumCanonMeasureIntegerBE.Apply(fraction_qarr_BE);
                            }
#line hidden
                            catch (Exception __arg5__)
                            {
                                __arg4__ = __arg5__;
                                throw __arg4__;
                            }
#line hidden
                            finally
                            {
                                if (__arg4__ != null)
                                {
                                    throw __arg4__;
                                }

#line hidden
                                Release.Apply(fraction_qarr);
                            }
                        }

#line 36 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                        ResetAll.Apply(eigenstate_register?.Copy());
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(eigenstate_register);
                    }
                }

#line 38 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                if ((approx_sr == 0L))
                {
#line 39 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                    throw new ExecutionFailException("We got 0 for the numerator. Process failed");
                }

#line 41 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                var (numerator,period) = MicrosoftQuantumCanonContinuedFractionConvergent.Apply((new Microsoft.Quantum.Canon.Fraction((approx_sr, 2L.Pow(bit_precision))), modulo)).Data;
#line 42 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                var (abs_numerator,abs_period) = (MicrosoftQuantumExtensionsMathAbsI.Apply(numerator), MicrosoftQuantumExtensionsMathAbsI.Apply(period));
#line 43 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                result = ((abs_period * result) / MicrosoftQuantumCanonGCD.Apply((result, abs_period)));
                if ((MicrosoftQuantumCanonExpMod.Apply((generator, result, modulo)) == 1L))
                {
                    break;
                }
                else
                {
#line 46 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                    Message.Apply(String.Format(" {0} Found: ", result));
#line 47 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
                    Message.Apply("Finding the right divisor of the period by trying again...");
                }
            }

#line 50 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.MicrosoftQuantumCanonContinuedFractionConvergent = this.Factory.Get<ICallable<(Microsoft.Quantum.Canon.Fraction,Int64), Microsoft.Quantum.Canon.Fraction>>(typeof(Microsoft.Quantum.Canon.ContinuedFractionConvergent));
            this.MicrosoftQuantumCanonExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.MicrosoftQuantumCanonGCD = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.GCD));
            this.MicrosoftQuantumCanonInPlaceXorLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.InPlaceXorLE));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Canon.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.MicrosoftQuantumCanonQuantumPhaseEstimation = this.Factory.Get<IUnitary<(Microsoft.Quantum.Canon.DiscreteOracle,QArray<Qubit>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.QuantumPhaseEstimation));
            this.MicrosoftQuantumExtensionsMathAbsI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.AbsI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.order_Finding = this.Factory.Get<IUnitary<(Int64,Int64,Int64,QArray<Qubit>)>>(typeof(order_Finding));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 generator, Int64 modulo)
        {
            return __m__.Run<find_Period, (Int64,Int64), Int64>((generator, modulo));
        }
    }
}