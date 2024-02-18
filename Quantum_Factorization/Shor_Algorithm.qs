

namespace Quantum_Factorization
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;

    operation order_Finding(generator: Int, modulo: Int, power: Int, target: Qubit[]): Unit{
        body(...){
            ModularMultiplyByConstantLE(ExpMod(generator,power,modulo),modulo,LittleEndian(target));
        }
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }


    operation find_Period (generator: Int, modulo: Int) : Int {
        Message("Performing Quantum Operations!");
        mutable result = 1;
        let qreg_size1 = BitSize(modulo);
        let bit_precision = 2*qreg_size1+1;     //For precision of s/r
        repeat{
                mutable approx_sr = 0;           //dyadic fraction numerator
            using (eigenstate_register = Qubit[qreg_size1]){
                let eigenstate_regLE = LittleEndian(eigenstate_register);
                InPlaceXorLE(1,eigenstate_regLE);
                let period_oracle = DiscreteOracle(order_Finding(generator,modulo,_,_));
                using (fraction_qarr = Qubit[bit_precision]){
                    let fraction_qarr_BE = BigEndian(fraction_qarr);
                    QuantumPhaseEstimation(period_oracle,eigenstate_regLE!,fraction_qarr_BE);
                    set approx_sr = MeasureIntegerBE(fraction_qarr_BE);
                }
                ResetAll(eigenstate_register);
            }
            if(approx_sr==0){
                fail "We got 0 for the numerator. Process failed";
            }
            let (numerator,period) = (ContinuedFractionConvergent(Fraction(approx_sr,2^bit_precision),modulo))!;
            let (abs_numerator, abs_period) = (AbsI(numerator),AbsI(period));
            set result = (abs_period*result)/GCD(result,abs_period);
        } until (ExpMod(generator,result,modulo)==1)
        fixup{
            Message($" {result} Found: ");
            Message("Finding the right divisor of the period by trying again...");
        }

        return result;
    }
}
