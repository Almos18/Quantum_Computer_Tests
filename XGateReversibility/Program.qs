namespace XGateReversibility {

    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    
    @EntryPoint()
    operation TestReversibility() : Result[] 
    {
        // Declaring 10 qubits with the initial value of 0.
        use qubits = Qubit[10];

        // Putting the qubits through the first X gate
        ApplyToEach(X, qubits);

        // Putting the qubits through the second X gate to return the initial qubit value of 0
        ApplyToEach(X, qubits);
        return MultiM(qubits);
    }
}
