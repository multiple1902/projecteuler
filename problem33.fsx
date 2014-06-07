(* Project Euler Problem 33
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 99

let lbound = 10

type fraction = { numerator: int; denominator: int; }

let rec gcd a b = 
    let _min = min a b
    let _max = max a b
    if _min = 0 then _max else
    gcd _min (_max % _min)
    
let simplify frac = 
    let divisor = gcd frac.numerator frac.denominator
    { numerator   = frac.numerator   / divisor;
      denominator = frac.denominator / divisor }

let test frac = 
    if frac.numerator % 10 = frac.denominator / 10 then
        let newfrac = { numerator   = frac.numerator / 10;
                        denominator = frac.denominator % 10 }
        let newfrac_s = simplify newfrac
        let frac_s = simplify frac
        newfrac_s.Equals(frac_s)
    elif frac.numerator / 10 = frac.denominator % 10 then
        let newfrac = { numerator   = frac.numerator % 10;
                        denominator = frac.denominator / 10 }
        let newfrac_s = simplify newfrac
        let frac_s = simplify frac
        newfrac_s.Equals(frac_s)
    else false

let fracs = seq {
    for i in lbound .. ubound do
        for j in (i + 1) .. ubound do
            let frac = { numerator = i;
                         denominator = j }
            if test frac then
                yield frac
}

let fracMul frac1 frac2 = 
    { numerator   = frac1.numerator   * frac2.numerator
      denominator = frac1.denominator * frac2.denominator }
    |> simplify

let product = Seq.fold fracMul
                       { numerator   = 1;
                         denominator = 1 }
                       fracs 

let problem33 = product.denominator 
    
let main = printfn "The answer is %d." (problem33)

main
