let mutable x = 10
let mutable y = 20

let add x y =  x + y

let inline mutableAdd x y = 
    x <- x + y
    y

printf "%A" (add x y) // 30
printf "%A %A" x y // 10 20

mutableAdd &x &y

printf "%A %A" x y // 30 20