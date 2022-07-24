using System;
using System.Collections.Generic;

namespace DesignPatterns.Decorator.Exercise
{
    public class Editor
    {
        public void OpenProject(string path)
        {
            Artefact[] artefacts =
            {
                new("Main"),
                new("Demo"),
                new("EmailClient"),
                new("EmailProvider"),
            };

            artefacts[0].SetMain(true);
            artefacts[2].SetHasError(true);

            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}