﻿module RecycleBin.Random.Array

/// <summary>
/// Creates an array whose elements are randomly generated. 
/// </summary>
/// <param name="count">The length of the array to create.</param>
/// <param name="generator">The generator function.</param>
val randomCreate : count:int -> generator:State<PrngState<'s>, 'a> -> State<PrngState<'s>, 'a []>

/// <summary>
/// Creates a new array whose elements are random set of the elements of the specified array.
/// </summary>
/// <param name="array">The array to shuffle.</param>
/// <seealso cref="shuffleInPlace" />
val shuffle : array:'a [] -> State<PrngState<'s>, 'a []>

/// <summary>
/// Shuffles the elements of the specified array by mutating it in-place.
/// </summary>
/// <param name="array">The array to shuffle.</param>
/// <seealso cref="shuffle" />
val shuffleInPlace : array:'a [] -> State<PrngState<'s>, unit>

/// <summary>
/// Picks up random samples without replacement in the specified array.
/// </summary>
/// <param name="n">The number of samples to pick up.</param>
/// <param name="source">The source array.</param>
/// <seealso cref="sampleWithReplacement" />
val sample : n:int -> source:'a [] -> State<PrngState<'s>, 'a []>

/// <summary>
/// Picks up random samples with replacement in the specified array.
/// </summary>
/// <param name="n">The number of samples to pick up.</param>
/// <param name="source">The source array.</param>
/// <seealso cref="sample" />
val sampleWithReplacement : n:int -> source:'a [] -> State<PrngState<'s>, 'a []>
