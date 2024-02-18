namespace TeleportationOnHardware 
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Measurement;
    
    @EntryPoint()
    operation TeleportClassicalMessage () : Bool 
    {
        let message = true;
        // Ask for some qubits that we can use to teleport.
        use (msg, target) = (Qubit(), Qubit());

        // Encode the message we want to send.
        if (message) {
            X(msg);
        }

        // Use the operation we defined.
        Teleport(msg, target);

        // Check what message was sent.
        return MResetZ(target) == One;
    }


     operation Teleport (msg : Qubit, target : Qubit) : Unit 
    {
        use register = Qubit();
        // Create some entanglement that we can use to send our message.
        H(register);
        CNOT(register, target);

        // Encode the message into the entangled pair.
        CNOT(msg, register);
        H(msg);

        if (MResetZ(msg) == One) { Z(target); }
        // We can also use library functions such as IsResultOne to write
        // out correction steps. This is especially helpful when composing
        // conditionals with other functions and operations, or with partial
        // application.
        if (IsResultOne(MResetZ(register))) { X(target); }
    }
}
