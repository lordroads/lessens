namespace lessens{
    class MessageSingle : IMessage{
        private string _text;
        protected string _recipient;

        protected MessageSingle(string text, string recipient = "NONE"){
            _text = string.Join(' ', $"[ {recipient} ]", text);
            _recipient = recipient;
        }

        public string GetRecipient() => _recipient;

        public string GetText() => _text;

        public int Length() => _text.Length;
    }
}