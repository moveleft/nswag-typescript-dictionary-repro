namespace tmp_nswag
{
    using System;
    using NJsonSchema;
    using NJsonSchema.CodeGeneration.TypeScript;
    using NSwag;
    using NSwag.CodeGeneration.TypeScript;

    class Program
    {
        static void Main(string[] args)
        {
            var document = SwaggerDocument.FromFileAsync("./swagger-doc.json").Result;

            var settings = new SwaggerToTypeScriptClientGeneratorSettings
            {
                TypeScriptGeneratorSettings =
                {
                    TypeScriptVersion = 2.3m,
                    TypeStyle = TypeScriptTypeStyle.Class,
                    NullHandling = NullHandling.Swagger
                },
                Template = TypeScriptTemplate.Angular
            };

            var generator = new SwaggerToTypeScriptClientGenerator(document, settings);
            Console.WriteLine(generator.GenerateFile());
        }
    }
}
