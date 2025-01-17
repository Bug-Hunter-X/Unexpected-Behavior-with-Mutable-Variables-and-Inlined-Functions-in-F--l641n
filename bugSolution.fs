let mutable x = 10
let mutable y = 20

let add x y =  x + y

let inline mutableAdd x y = 
    x <- x + y
    y

printf "%A" (add x y) // 30
printf "%A %A" x y // 10 20

// Understanding the changes - x and y are passed by reference (because of &), so the function will modify the values in x and y directly. 
mutableAdd &x &y

printf "%A %A" x y // 30 20 // The values are modified as expected.

// Alternative approach using tuples to avoid mutable parameters and make it more functional. 
let addTuple (x, y) = (x + y, x, y)

let x2 = 10
let y2 = 20

let (sum, newX, newY) = addTuple (x2, y2)
printfn "Sum: %d, x: %d, y: %d" sum newX newY