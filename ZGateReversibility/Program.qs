namespace ZGateReversibility {

     open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;
    
    @EntryPoint()
    operation TestReversibility() : Result[] 
    {
        // Declaring 10 qubits with the initial value of 0.
        use qubits = Qubit[10];

        // Putting the qubits in superposition so the Z gate can be used.
        ApplyToEach(H, qubits);
        // Changing the phase of the qubits so if put through a H gate at this point it should return 1.
        ApplyToEach(Z, qubits);
        // Changing the phase back to the initial value.
        ApplyToEach(Z, qubits);
        // Changing the qubits back to the initial value of 0.
        ApplyToEach(H, qubits);

        return MultiM(qubits);
    }
}
