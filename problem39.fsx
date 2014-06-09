(* Project Euler Problem 39
 * By Weisi Dai <weisi@x-research.com>
 *)

let ubound = 1000

let triangleInequality a b c =
    (c < a + b) && (c > b - a)

let formsTriangle a b c =
    (triangleInequality a b c)
 && (triangleInequality b c a)
 && (triangleInequality c a b)

let formsRightTriangle a b c = // a <= b <= c
    (formsTriangle a b c)
 && (pown a 2 + pown b 2 - pown c 2 = 0)

let rightTrianglesOfSum sum = seq {
        for a in 1 .. sum / 3 do
            for b in a .. (sum - a) / 2 do
                let c = sum - a - b
                if formsRightTriangle a b c then
                    yield (a, b, c)
    }

let rightTrangles = seq {
    for sum in 3 .. ubound do
        yield (sum, Seq.length (rightTrianglesOfSum sum))
}

let problem39 = rightTrangles |> Seq.maxBy snd |> fst
    
let main() = printfn "The answer is %d." (problem39)

main()
