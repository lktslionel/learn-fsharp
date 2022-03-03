# F#






## Contents

* 01 - [Quickstart]
* 02 - [Variables & data types]
* 03 - [Loops]
* 04 - [Functions]
* 05 - [Errors handling & Exceptions]
* 06 - [OOP]
* 07 - [Collections]
* 08 - [Advanced concepts]
* 09 - [Resources]

<br>

## 01 - Quickstart

### Install

<br>

## 02 - Basic concepts



### 02.1. Variables & data types

**F#** is statically typed. Therefore the following statement will failed.

```fsharp
printfn "Value %s" 1
// %s is a placeholder for a string
```

Variables define using let are immutable by default. To mark a var as mutable, you need to prefix the variable with `mutable` 

```fsharp
let variable = "value"

let mutable variable = "value"
variable <- "new value"
```

### 02.2. Conditional Branching

```fsharp 

if <condition> then 
    //<logic>
```

You can also assign the result of a conditional to a variable as follows

```fsharp
let result = 
    if <condition> then
        //<expr>
    else
        //<expr>
```


<br>

## 03 - Loops & Iterations

### 03.1. Simple form

```fsharp
for i in 0..10 do 
    //<statements>
```

### 03.2. iterators

Omit the indexed-based approach.

```fsharp
for arg in args do 
    //<statements>
```

You can also use `Array.Iter <fn> <array>`

```fsharp
let echo v = 
    printfn "val: %s" v

Array.Iter echo argv
```






<br>

## 04 - Functions

In **F#**, the last statement is an implicit return value.

```fsharp 

let main argv = 
    //[...]
    0 // Implicit return value

```


> `argv` does not contain the name of the program at position `0`. It starts with the first arg value.
>
> To access values in the array, you must use at dot (`.`) as follows: `argv.[0]`

<br>

## 05 - Errors handling & Exceptions


<br>

## 06 - OOP


<br>

## 07 - Collections 

### 07.1. Arrays

Use `argv.Length` to get the size of an array. 

<br>

## 08 - Advanced concepts 


### Testing


### Design patterns

<br>

## 09 - Resources 

### Code samples
<!-- Links -->
[Quickstart]: #01-quickstart  
[Variables & data types]: #02-variables-data-types
[Loops]: #03-loops
[Functions]: #04-functions   
[Errors handling & Exceptions]: #05-errors-handling-exceptions
[OOP]: #06-oop
[Collections]: #07-collections
[Advanced concepts]: #08-advanced-concepts
[Resources]: #09-resources
