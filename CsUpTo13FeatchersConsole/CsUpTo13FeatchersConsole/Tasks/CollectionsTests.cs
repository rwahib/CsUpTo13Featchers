
using System.Collections;

namespace CsUpTo13FeatchersConsole.Tasks
{
    public class CollectionsTests : TaskSampleHelper, ITask
    {
        public string Name { get; init; }
        public string Description { get; init; }

        public CollectionsTests()
        {
            Name = "Collection samples";
            Description = "Different type of samples";
        }

        public Task<bool> RunAsync()
        {

            this.CollectionLiterals();
            return Task.FromResult(true);
        }

        private void CollectionLiterals()
        {
            // Create an array:
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8,9,10,11,12];
            var a = numbers[0..8]; // {2, 3}

            
            // Create a list:
            List<string> b = ["one", "two", "three"];

            // Create a span
            Span<char> c = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];

            // Create a jagged 2D array:
            int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

            // Create a jagged 2D array from variables:
            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            

            int[] unionArray = [.. row0, .. row1, .. row2];
            
            List<int> unionList = [.. row0, .. row1, .. row2];
            
            Span<int> unionSpan = [.. row0, .. row1, .. row2];


            var samples = new List<CollectionSample<IEnumerable>>();

            samples.Add(new CollectionSample<IEnumerable>("sliced array [0..8]",a.AsEnumerable()));
            samples.Add(new CollectionSample<IEnumerable>("generic string list",b.AsEnumerable()));
            samples.Add(new CollectionSample<IEnumerable>("generic string Span",c.ToArray().AsEnumerable()));
            
            samples.Add(new CollectionSample<IEnumerable>("Union Array",unionArray.AsEnumerable()));
            samples.Add(new CollectionSample<IEnumerable>("Union List", unionList.AsEnumerable()));
            samples.Add(new CollectionSample<IEnumerable>("Union Span", unionSpan.ToArray().AsEnumerable()));


            foreach (var sample in samples)
            {
                Console.WriteLine("");
                Console.WriteLine($"Collection type: {sample.SampleName}" );
                Console.WriteLine($"Sample values: " );

                foreach (var item in sample.Collection)
                {
                    Console.Write($"{item}, ");
                }
            }


        }




    }


     record class CollectionSample<T>where T:IEnumerable
    {
        public string SampleName { get; set; }
        public string? SampleDescription { get; set; } 
        public string? SampleCategory { get; set; }

        public T Collection { get; set; }

        public CollectionSample(string sampleName,T collection )
        {
            Collection = collection;
            SampleName = sampleName;
        }
    }
}
