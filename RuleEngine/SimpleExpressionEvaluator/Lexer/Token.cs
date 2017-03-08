using System;

namespace SimpleExpressionEvaluator.Lexer
{
    public class Token
    {
        public TokenType Type { get; set; }
        public string Text { get; set; }

        public Token(TokenType type, string text)
        {
            Type = type;
            Text = text;
        }

        public override string ToString()
        {
            return string.Format("<'{0}'>,{1}", Text, Enum.GetName(typeof(TokenType), Type));
        }
    }
}
