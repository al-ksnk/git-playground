namespace NiceProject
{
    using System.Collections.Generic;

    internal class EmptyFileReader : IFileReader
    {
        public IEnumerable<int> ReadAllNumbers()
        {
<<<<<<< HEAD:nice-project/StubFileReader.cs
            return new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
=======
            return new int[0];
>>>>>>> another-merge-conflict-branch:nice-project/EmptyFileReader.cs
        }
    }
}