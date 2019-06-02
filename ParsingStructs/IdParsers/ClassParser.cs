namespace LabSOLID.ParsingStructs.IdParsers
{
    public class ClassParser : BaseIdParser
    {
        protected override string Pattern => @"^class\s+(?!(ref|out|int|char|bool|string|float)\s*;)[^\d\s]\w*\s*;$";

        public override Id Parse(string source)
        {
            if (!CanHandle(source))
                return null;
            
            source = source.TrimEnd(' ', ';');
            var inp = source.Split(' ');
            return new Class(inp[1]);
        }
    }
}