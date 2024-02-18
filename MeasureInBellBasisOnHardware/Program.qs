namespace MeasureInBellBasisOnHardware 
{
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Measurement;
    
    @EntryPoint()
     operation MeasureInBellBasis() : (Result, Result) 
     {

        // The following using block allocates a pair of fresh qubits, which
        // start off in the |00〉 state by convention.
        use left = Qubit();
        use right = Qubit();

        // By applying the Hadamard and controlled-NOT (CNOT) operations,
        // we can prepare our qubits in an equal superposition of |00⟩ and
        // |11⟩. This state is sometimes known as a Bell state.
        H(left);
        CNOT(left, right);

        // Finally, we measure each qubit in the Z-basis and return the
        // results.
        return (MResetZ(left), MResetZ(right));
    }
}
