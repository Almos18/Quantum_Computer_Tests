namespace Microsoft.Quantum.Samples.Measurement {
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Measurement;

    @EntryPoint()
    operation DoubleHGate() : Result {

        use qubit = Qubit();

        // Set qubit to One with invert gate.
        X(qubit);

        // Set qubit to a superpositioned state of 50|50 and check if it is in a superpositioend state.
        H(qubit);
        AssertMeasurementProbability([PauliZ], [qubit], Zero, 0.5, "Error: Outcomes of the measurement must be equally likely", 1E-05);

        // Put into another H gate to hopefully reverse the qubit state and show H gate is reversible.
        H(qubit);

        let result = M(qubit);  

        return result;
       
    }


    @EntryPoint()
    operation RunProgram() : Unit {
        Message("## DoubleHGate() ##");
        mutable count = 0;

        for idx in 0..99 {
            set count += DoubleHGate() == One ? 1 | 0;
        }

        Message($"Estimated probability of 1 given initial qubit probability of H|1> put through double H gates: {count} / 100");

       
    }

}


