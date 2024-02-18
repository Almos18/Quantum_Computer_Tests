namespace NineteenXGates {

    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Canon;
    
    @EntryPoint()
    operation XGates() : Result[]  {
        // Declaring 10 qubits with the initial value of 0.
        use qubits = Qubit[10];

        // Putting the qubits through the first X gate
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);

        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);

        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);

        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);
        ApplyToEach(X, qubits);

        return MultiM(qubits);
    }
}