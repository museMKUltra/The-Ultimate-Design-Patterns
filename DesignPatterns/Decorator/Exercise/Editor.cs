using System;
using System.Collections.Generic;

namespace DesignPatterns.Decorator.Exercise
{
    public class Editor
    {
        public void OpenProject(string path)
        {
            IArtefact[] artefacts =
            {
                new Main(new Artefact("Main")),
                new Artefact("Demo"),
                new Error(new Artefact("EmailClient")),
                new Artefact("EmailProvider"),
            };

            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}