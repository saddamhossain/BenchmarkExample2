using BenchmarkDotNet.Running;
using BenchmarkExample2;

BenchmarkRunner.Run < nameof(IntroBenchmarkBaseline) > ();

Console.ReadKey();
