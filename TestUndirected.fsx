#r "nuget: FSharp.Data"
#load "./UndirectedGraph.fsx"
#load "./UndirectedHelpers.fsx"

open FSharp.Data
open System.IO

open UndirectedHelpers
open UndirectedGraph


let powerGridGraph = createFromEdgeList "C:/Projects/Doodles/powergrid.edgelist.txt" "\t" 0 false

// Karate Graph Tests
//http://konect.cc/networks/ucidata-zachary/
let karateGraph = createFromEdgeList "C:/Projects/Doodles/zachary.txt" " " 2 false

karateGraph.Size() // should be 34
karateGraph.Volume() // should be 78
karateGraph.MeanDegree() // should be 4.588 24

//Editing operations Tests
let mutable testGraph = UndirectedGraph<int>()

testGraph.AddNode 1
testGraph.AddNode 2
testGraph.AddNode 3
let edge = (1,3)
testGraph.AddEdge edge

testGraph.Size() // should be 3
testGraph.Volume() // should be 1
testGraph.MeanDegree() // should be 4.588 24



