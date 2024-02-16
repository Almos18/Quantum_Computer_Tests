namespace TwentyHGatesHardware {

    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Canon;

    @EntryPoint()
    operation GenerateRandomBits() : Result[] {
        use qubits = Qubit[10];
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);

        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);

        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);
        ApplyToEach(H, qubits);

        return MultiM(qubits);
    }
}
